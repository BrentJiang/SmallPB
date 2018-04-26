<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:variable name="bizdata" select="'${BIZDATA_SCHEMA}'"/>
  <xsl:variable name="sync" select="'${SYNC_SCHEMA}'"/>
  <xsl:variable name="trade" select="'${TRADE_SCHEMA}'"/>
  <xsl:variable name="dump" select="'${DUMP_SCHEMA}'"/>
  <xsl:variable name="settle" select="'${SETTLE_SCHEMA}'"/>
  <xsl:template match="/"><![CDATA[<?xml version="1.0" encoding="GBK"?>
<EntityModel version="1.0">
  <Entities>
]]>
 <xsl:for-each select="/EntityModel/Entities/Entity[@dbTable='yes']">
   <xsl:variable name="unionFlag" select="@name='--no-union-now-'"/>
      <![CDATA[
	  <Entity name="]]><xsl:value-of select="@name"/><![CDATA[" title="]]><xsl:value-of select="@title"/><xsl:if test="$unionFlag"><![CDATA[" union="]]>1</xsl:if><![CDATA[">
	        <refdb>]]><no_new_line />
			 <xsl:choose><xsl:when test="@name='TradeDate'"><xsl:value-of select="$bizdata"/><no_new_line />
				</xsl:when>
         <xsl:when test="@name='AccountAsset' or @name='ComboPosition' or @name='Order' or @name='Trade' or @name='PosChangeLog' or @name='ActChangeLog' or @name='RiskRuleLog' or @name='OperationLog'  or @name='Instrument' or $unionFlag"><xsl:value-of select="$trade"/><no_new_line />
				</xsl:when>
				 <xsl:otherwise><xsl:value-of select="$bizdata"/><no_new_line />
         </xsl:otherwise>
       </xsl:choose> <no_new_line/><![CDATA[</refdb>]]>
       <xsl:if test="$unionFlag"><![CDATA[<refdb_other>]]><xsl:value-of select="$dump"/><![CDATA[</refdb_other>]]></xsl:if>
       <![CDATA[<reftable>]]><xsl:value-of select="@name"/><![CDATA[</reftable>
      </Entity>
	]]><no_new_line />
 </xsl:for-each>
 
  <xsl:for-each select="/EntityModel/Entities/Entity">
    <xsl:choose>
      <xsl:when test="@name='AccountAsset' or @name='ComboPosition' or @name='Order' or @name='Trade' or @name='PosChangeLog' or @name='ActChangeLog' or @name='RiskRuleLog' or @name='OperationLog'">
        <![CDATA[
	  <Entity name="His]]><xsl:value-of select="@name"/><![CDATA[" title="His]]><xsl:value-of select="@title"/><![CDATA[">
	        <refdb>]]><xsl:value-of select="$dump"/><![CDATA[</refdb>
	        <reftable>]]><xsl:value-of select="@name"/><![CDATA[</reftable>
      </Entity>
	]]><no_new_line /> 
      </xsl:when>
      <xsl:otherwise>
      </xsl:otherwise>
    </xsl:choose>
    </xsl:for-each>

    <xsl:for-each select="/EntityModel/Entities/Entity">
      <xsl:choose>
        <xsl:when test="@name='PosChangeLog' or @name='ComboPosition'">
          <![CDATA[
	  <Entity name="Settle]]><xsl:value-of select="@name"/><![CDATA[" title="Settle]]><xsl:value-of select="@title"/><![CDATA[">
	        <refdb>]]><xsl:value-of select="$settle"/><![CDATA[</refdb>
	        <reftable>]]><xsl:value-of select="@name"/><![CDATA[</reftable>
      </Entity>
	]]><no_new_line />
        </xsl:when>
        <xsl:otherwise>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>
    <![CDATA[
  </Entities>
  </EntityModel>
]]>
  </xsl:template>
</xsl:stylesheet>
