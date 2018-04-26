<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="/"> <nonewline/>
#ifndef TF_BIZ_DEFS_H
#define TF_BIZ_DEFS_H
#include "model/AppNs.h"
_TFZQ_STP_APP_NS_BEGIN_
    <xsl:for-each select="/EntityModel/Entities/Entity"> <nonewline/>
const int TF_FID_<xsl:value-of select="@name"/> = 0x2000 + <xsl:value-of select="position()"/> ; <nonewline/>
    </xsl:for-each>
    
_TFZQ_STP_APP_NS_END_
#endif
</xsl:template>

</xsl:stylesheet>