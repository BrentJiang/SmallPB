<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>

  <xsl:template match="/"><nonewline />
<![CDATA[#ifndef SBE_ENTITY_UTILS_H
#define SBE_ENTITY_UTILS_H

#include "base/Public.h"
#include "tfpbapi/TFDataStruct.h"
#include "SbeEntity.h"
#include "sbebiz/SbeBase.h"
#include "BizDefs.h"

_TFZQ_STP_APP_NS_BEGIN_

//报单回报 
class SbeEntityUtils 
{
public: 
]]>   
/////////////////////////////////////////////////////////////
//// transfer SbeEntity to  TFEntity
/////////////////////////////////////////////////////////////
    <xsl:for-each select="/EntityModel/Entities/Entity">
  ///to Sbe<xsl:value-of select="@name"/>
  static void fillSbe<xsl:value-of select="@name"/>(Sbe<xsl:value-of select="@name"/> &amp;sbeEntity, TF<xsl:value-of select="@name"/>Field *pEntity)
  {
      sbeEntity<nonewline/>
      <xsl:for-each select="Field">
        <xsl:variable name="pos" select="position()"/>
        <xsl:variable name="lst" select="last()"/>
        <xsl:variable name="name" select="@name"/>
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:variable name="nodeName" select="@name"/>
            <xsl:choose>
              <xsl:when test="@type='String'">
        .put<xsl:value-of select="@name"/>(pEntity-><xsl:value-of select="@name"/>)<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Int'">
        .<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>(pEntity-><xsl:value-of select="@name"/>)<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Double'">
        .<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>(pEntity-><xsl:value-of select="@name"/>)<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Date'">
        .put<xsl:value-of select="@name"/>(pEntity-><xsl:value-of select="@name"/>)<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Time'">
        .put<xsl:value-of select="@name"/>(pEntity-><xsl:value-of select="@name"/>)<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Bool'">
        .<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>(pEntity-><xsl:value-of select="@name"/>)<no_new_line />
              </xsl:when>
              <xsl:when test="@type='EnumChar'">
        .<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>(pEntity-><xsl:value-of select="@name"/>)<no_new_line />
              </xsl:when>
              <xsl:otherwise>
                <xsl:message>
                  TYPE DOES NOT EXIST![<xsl:value-of select="@type"/>]
                </xsl:message>
              </xsl:otherwise>
            </xsl:choose>
          <xsl:if test="$pos=$lst">;
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
  }
    </xsl:for-each>

/////////////////////////////////////////////////////////////
//// transfer TFEntity to SbeEntity
/////////////////////////////////////////////////////////////
    <xsl:for-each select="/EntityModel/Entities/Entity">
    ///from Sbe<xsl:value-of select="@name"/>
    static void fillTF<xsl:value-of select="@name"/>(TF<xsl:value-of select="@name"/>Field *pEntity, Sbe<xsl:value-of select="@name"/> &amp;sbeEntity)
    {
      <xsl:for-each select="Field">
        <xsl:variable name="name" select="@name"/>
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:variable name="nodeName" select="@name"/>      
            <xsl:choose>
              <xsl:when test="@type='String'">
        memcpy(pEntity-><xsl:value-of select="@name"/>, sbeEntity.<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>(), sizeof(pEntity-><xsl:value-of select="@name"/>)); <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Int'">
        pEntity-><xsl:value-of select="@name"/> = sbeEntity.<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>();<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Double'">
        pEntity-><xsl:value-of select="@name"/> = sbeEntity.<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>();<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Date'">
        memcpy(pEntity-><xsl:value-of select="@name"/>, sbeEntity.<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>(), sizeof(pEntity-><xsl:value-of select="@name"/>)); <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Time'">
        memcpy(pEntity-><xsl:value-of select="@name"/>, sbeEntity.<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>(), sizeof(pEntity-><xsl:value-of select="@name"/>)); <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Bool'">
        pEntity-><xsl:value-of select="@name"/> = sbeEntity.<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>() == 0 ? false : true;<no_new_line />
              </xsl:when>
              <xsl:when test="@type='EnumChar'">
        pEntity-><xsl:value-of select="@name"/> = sbeEntity.<xsl:value-of select="translate(substring($nodeName,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($nodeName,2)"/>();<no_new_line />
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
_TFZQ_STP_APP_NS_END_

#endif 
  </xsl:template>
</xsl:stylesheet>