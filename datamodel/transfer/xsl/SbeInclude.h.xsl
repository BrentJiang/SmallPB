<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="/"> <nonewline/>
#pragma warning(disable : 4068)
#pragma warning(disable : 4244)
    <xsl:for-each select="/EntityModel/Entities/Entity"> <nonewline/>
#include "<xsl:value-of select="@name"/>_In.h" <nonewline/>
    </xsl:for-each>
#pragma warning(default:4244)
#pragma warning(default:4068)
  </xsl:template>
  
</xsl:stylesheet>