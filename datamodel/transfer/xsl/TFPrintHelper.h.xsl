<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>


  <xsl:template match="/">
<![CDATA[
#ifndef TF_PRINT_HELPER_H
#define TF_PRINT_HELPER_H
        
#define TFLOGSTR(v) "\n\t" #v "\t\t:[" << (strlen(v) == 0 ? "" : (v)) << "]"
#define TFLOGCOM(v) "\n\t" #v "\t\t:[" << (v) << "]"
#define TFLOGCHAR(v) "\n\t" #v "\t\t:[" << ((v) == 0 ? '`' : (v)) << "]"
#define TFLOGBOOL(v) "\n\t" #v "\t\t:[" << ((v) == 0 ? '0' : ('1')) << "]"
]]>
    <xsl:for-each select="/EntityModel/Entities/Entity">
        <xsl:variable name="entityName" select="@name"/>
#define TFLOG<xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>(p<xsl:value-of select="@name"/>)         "\n <xsl:value-of select="@name"/>:"\<no_new_line />
      <xsl:for-each select="Field">
        <xsl:variable name="currPosition" select="position()"/>
        <xsl:variable name="lastPosition" select="last()"/>
        <xsl:variable name="name" select="@name"/>
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:if test="position()=last()">
<xsl:choose>
  <xsl:when test="@type='String'">
    &lt;&lt; TFLOGSTR((p<xsl:value-of select="$entityName"/>)-><xsl:value-of select="$name"/>)\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Int'">
    &lt;&lt; TFLOGCOM((p<xsl:value-of select="$entityName"/>)-><xsl:value-of select="$name"/>)\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Double'">
    &lt;&lt; TFLOGCOM((p<xsl:value-of select="$entityName"/>)-><xsl:value-of select="$name"/>)\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Date'">
    &lt;&lt; TFLOGSTR((p<xsl:value-of select="$entityName"/>)-><xsl:value-of select="$name"/>)\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Time'">
    &lt;&lt; TFLOGSTR((p<xsl:value-of select="$entityName"/>)-><xsl:value-of select="$name"/>)\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Bool'">
    &lt;&lt; TFLOGBOOL((p<xsl:value-of select="$entityName"/>)-><xsl:value-of select="$name"/>)\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='EnumChar'">
    &lt;&lt; TFLOGCHAR((p<xsl:value-of select="$entityName"/>)-><xsl:value-of select="$name"/>)\<no_new_line />
  </xsl:when>
  <xsl:otherwise>
    <xsl:message>
      TYPE DOES NOT EXIST![<xsl:value-of select="@type"/>]
    </xsl:message>
  </xsl:otherwise>
</xsl:choose>
          </xsl:if>
        </xsl:for-each>
        <xsl:if test ="$currPosition = $lastPosition">
    &lt;&lt; ";"
        </xsl:if>
      </xsl:for-each>
      
    </xsl:for-each>
#endif
  </xsl:template>
</xsl:stylesheet>