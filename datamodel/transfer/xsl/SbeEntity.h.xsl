<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="/"> <nonewline />
<![CDATA[#ifndef SBE_ENTITY_H
#define SBE_ENTITY_H

#include "base/Public.h"
#include "tfzq/SbeInclude.h"
#include "sbebiz/SbeBase.h"
#include "BizDefs.h"

_USING_TFZQ_COMMON_NS_
_TFZQ_STP_APP_NS_BEGIN_

const int MAX_ENTITY_SIZE = 3072;  //最大实体不能超过MAX_ENTITY_SIZE字节
]]>    
    <xsl:for-each select="/EntityModel/Entities/Entity">
      <xsl:variable name="entity_id" select="position()" />
 //<xsl:value-of select="@title"/>
class Sbe<xsl:value-of select="@name"/> : public SbeBase, public <xsl:value-of select="@name"/>_In
{
public:
    Sbe<xsl:value-of select="@name"/>();
    virtual ~Sbe<xsl:value-of select="@name"/>();
    virtual bool serializeToData(char * data, int len);
    virtual int  getDataSize();
    virtual bool parseFromData(const char * data, int len);

    Sbe<xsl:value-of select="@name"/>(const Sbe<xsl:value-of select="@name"/>&amp; other);
    Sbe<xsl:value-of select="@name"/>&amp; operator =(const Sbe<xsl:value-of select="@name"/>&amp; other);
private:
    char buffer_[MAX_ENTITY_SIZE];  
};
</xsl:for-each>
    
_TFZQ_STP_APP_NS_END_

#endif     
  </xsl:template>
  
</xsl:stylesheet>