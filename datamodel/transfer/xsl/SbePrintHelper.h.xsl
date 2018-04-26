<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>


  <xsl:template match="/">
<![CDATA[
#ifndef SBE_PRINT_HELPER_H
#define SBE_PRINT_HELPER_H

#define SBELOGSTR(v) "\n\t" #v "\t\t:[" << (strlen(v) == 0 ? "" : (v)) << "]"
#define SBELOGCOM(v) "\n\t" #v "\t\t:[" << (v) << "]"
#define SBELOGCHAR(v) "\n\t" #v "\t\t:[" << ((v) == 0 ? '`' : (v)) << "]"
#define SBELOGBOOL(v) "\n\t" #v "\t\t:[" << ((v) == 0 ? '0' : ('1')) << "]"
]]>
    <xsl:for-each select="/EntityModel/Entities/Entity">
        <xsl:variable name="entityName" select="@name"/>
#define SBELOG<xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>(sbe<xsl:value-of select="@name"/>)         "\n Sbe<xsl:value-of select="@name"/>:"\<no_new_line />
      <xsl:for-each select="Field">
        <xsl:variable name="currPosition" select="position()"/>
        <xsl:variable name="lastPosition" select="last()"/>
        <xsl:variable name="name" select="@name"/>
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:if test="position()=last()">
<xsl:choose>
  <xsl:when test="@type='String'">
    &lt;&lt; SBELOGSTR((sbe<xsl:value-of select="$entityName"/>).<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>())\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Int'">
    &lt;&lt; SBELOGCOM((sbe<xsl:value-of select="$entityName"/>).<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>())\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Double'">
    &lt;&lt; SBELOGCOM((sbe<xsl:value-of select="$entityName"/>).<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>())\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Date'">
    &lt;&lt; SBELOGSTR((sbe<xsl:value-of select="$entityName"/>).<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>())\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Time'">
    &lt;&lt; SBELOGSTR((sbe<xsl:value-of select="$entityName"/>).<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>())\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Bool'">
    &lt;&lt; SBELOGBOOL((sbe<xsl:value-of select="$entityName"/>).<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>())\<no_new_line />
  </xsl:when>
  <xsl:when test="@type='EnumChar'">
    &lt;&lt; SBELOGCHAR((sbe<xsl:value-of select="$entityName"/>).<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>())\<no_new_line />
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