<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>

  <xsl:template match="/"><nonewline />
<![CDATA[#ifndef SBE_ENTITY_UTILS_H
#define SBE_ENTITY_UTILS_H

#include "base/Public.h"
#include "SbeEntity.h"
#include "SbeBase.h"
#include "BizDefs.h"

_TFZQ_NS_BEGIN_

//报单回报 
class SbeEntityUtils 
{
public: 
]]>
/////////////////////////////////////////////////////////////
//// transfer OriginEntity to SbeEntity
/////////////////////////////////////////////////////////////
    <xsl:for-each select="/EntityModel/Entities/Entity">
    ///from Sbe<xsl:value-of select="@name"/>
    static void fillOrigin<xsl:value-of select="@name"/>(<xsl:value-of select="@name"/> *pEntity, Sbe<xsl:value-of select="@name"/> &amp;sbeEntity)
    {
      <xsl:for-each select="Field">
        <xsl:variable name="name" select="@name"/>
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:variable name="nodeName" select="@name"/>      
            <xsl:choose>
              <xsl:when test="@type='String'"> <nonewline/>
        ASSERT_EQ(strcmp(originOrder.<xsl:value-of select="@name"/>, originOrder_1.<xsl:value-of select="@name"/>), 0); <nonewline/>
              </xsl:when>
              <xsl:when test="@type='Int'"><nonewline/>
        ASSERT_EQ(originOrder.<xsl:value-of select="@name"/>, originOrder_1.<xsl:value-of select="@name"/>);<nonewline/>
              </xsl:when>
              <xsl:when test="@type='Double'"> <nonewline/>
        ASSERT_EQ(originOrder.<xsl:value-of select="@name"/>, originOrder_1.<xsl:value-of select="@name"/>);<nonewline/>
              </xsl:when>
              <xsl:when test="@type='Date'"> <nonewline/>
        ASSERT_EQ(strcmp(originOrder.<xsl:value-of select="@name"/>, originOrder_1.<xsl:value-of select="@name"/>), 0);<nonewline/>
              </xsl:when>
              <xsl:when test="@type='Time'"><nonewline/>
        ASSERT_EQ(strcmp(originOrder.<xsl:value-of select="@name"/>, originOrder_1.<xsl:value-of select="@name"/>), 0);<nonewline/>
              </xsl:when>
              <xsl:when test="@type='Bool'"><nonewline/>
        ASSERT_EQ(originOrder.<xsl:value-of select="@name"/>, originOrder_1.<xsl:value-of select="@name"/>);<nonewline/>
              </xsl:when>
              <xsl:when test="@type='EnumChar'"><nonewline/>
        ASSERT_EQ(originOrder.<xsl:value-of select="@name"/>, originOrder_1.<xsl:value-of select="@name"/>);<nonewline/>
              </xsl:when>
              <xsl:otherwise>
                <xsl:message>
                  TYPE DOES NOT EXIST![<xsl:value-of select="@type"/>]
                </xsl:message>
              </xsl:otherwise>
            </xsl:choose>
        </xsl:for-each>
      </xsl:for-each>  
    }
    </xsl:for-each>
};
_TFZQ_NS_END_

#endif 
  </xsl:template>
</xsl:stylesheet>