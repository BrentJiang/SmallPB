<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="text()"/>
  <xsl:template match="/">
    <xsl:for-each select="/EntityModel/Entities/Entity">
      
-- 删除<xsl:value-of select="@name"/>视图
drop view IF EXISTS `<xsl:value-of select="@name"/>`;
-- 创建<xsl:value-of select="@name"/>视图 <xsl:choose><xsl:when test="@union='1'"> <no_new_line />
create view `<xsl:value-of select="@name"/>` as select * from `<xsl:value-of select="refdb"/>`.`<xsl:value-of select="reftable"/>` union all select * from `<xsl:value-of select="refdb_other"/>`.`<xsl:value-of select="reftable"/>`;<no_new_line />       
      </xsl:when>
      <xsl:otherwise>
create view `<xsl:value-of select="@name"/>` as select * from `<xsl:value-of select="refdb"/>`.`<xsl:value-of select="reftable"/>`; <no_new_line />
      </xsl:otherwise>
    </xsl:choose> 
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>