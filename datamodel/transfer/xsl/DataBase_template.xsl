<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="text()"/>
  <xsl:template match="/">
    <xsl:for-each select="/EntityModel/Entities/Entity[@dbTable='yes']">
-- 删除<xsl:value-of select="@name"/>表
drop table IF EXISTS `<xsl:value-of select="@name"/>`;

-- 创建<xsl:value-of select="@name"/>表
create table `<xsl:value-of select="@name"/>`
(
      <xsl:for-each select="Field">
        <xsl:variable name="name" select="@name"/>
        <xsl:variable name="position" select="position()" />
        <xsl:variable name="last" select="last()" />
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:variable name="length" select="@length" />
          <xsl:if test="$position != 1">
            <xsl:text>, </xsl:text>
          </xsl:if>
          <xsl:choose>
            <xsl:when test="@type='String'">
              <xsl:value-of select="@name"/> varchar(<xsl:value-of select="@length"/>) DEFAULT ''<no_new_line />
            </xsl:when>
            <xsl:when test="@type='Int'">
              <xsl:value-of select="@name"/> int <no_new_line />
          </xsl:when>
          <xsl:when test="@type='Double'">
            <xsl:value-of select="@name"/> double <no_new_line />
          </xsl:when>
            <xsl:when test="@type='Date'">
              <xsl:value-of select="@name"/> varchar(8) DEFAULT ''<no_new_line />
            </xsl:when>
            <xsl:when test="@type='Time'">
              <xsl:value-of select="@name"/> varchar(9) DEFAULT ''<no_new_line />
            </xsl:when>
            <xsl:when test="@type='Bool'">
              <xsl:value-of select="@name"/> boolean <no_new_line />
            </xsl:when>
            <xsl:when test="@type='EnumChar'">
              <xsl:value-of select="@name"/> char(1) DEFAULT ''<no_new_line />
            </xsl:when>
            <xsl:otherwise>
              <xsl:message>
                TYPE DOES NOT EXIST![<xsl:value-of select="@type"/>]
              </xsl:message>
            </xsl:otherwise>
          </xsl:choose>
        </xsl:for-each>
        <xsl:if test= "@notnull='yes'">
          <xsl:text> not null </xsl:text>
        </xsl:if>
        <xsl:text> comment '</xsl:text>
        <xsl:value-of select="@description"/>' 
      </xsl:for-each>
      <xsl:variable name="pk_loop" select="Field[@iskey='yes']"/>
      <xsl:if test="count($pk_loop)">
      <no_new_line>, constraint pk_<xsl:value-of select="@name"/> primary key (</no_new_line>
        <xsl:for-each select="$pk_loop">
          <xsl:choose>
            <xsl:when test="position()=1">
              <xsl:value-of select="@name"/>
            </xsl:when>
            <xsl:otherwise>
              <xsl:text>,</xsl:text>
              <xsl:value-of select="@name"/>
            </xsl:otherwise>
          </xsl:choose>
        </xsl:for-each>
        <xsl:text>)</xsl:text>
      </xsl:if>
) ENGINE=InnoDB ;
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>