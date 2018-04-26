<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="/"> <nonewline />
<![CDATA[#include "SbeEntity.h"

_USING_TFZQ_STP_APP_NS_
]]>    
          <xsl:for-each select="/EntityModel/Entities/Entity">
      <xsl:variable name="entity_id" select="position()" />
Sbe<xsl:value-of select="@name"/>::Sbe<xsl:value-of select="@name"/>() 
{
    memset(buffer_, 0, sizeof(buffer_));
    _fieldID = TF_FID_<xsl:value-of select="@name"/>;
    wrapForEncode(buffer_, 0, sbeBlockLength());
}

Sbe<xsl:value-of select="@name"/>::~Sbe<xsl:value-of select="@name"/>()
{

}


int Sbe<xsl:value-of select="@name"/>::getDataSize()
{
    return sbeBlockLength();
}

bool Sbe<xsl:value-of select="@name"/>::serializeToData(char * data, int len)
{
    NTS_ASSERT(sbeBlockLength() &lt;= MAX_ENTITY_SIZE);
    if (data == NULL || len &lt; sbeBlockLength()){
        return false;
    }
    memcpy(data, buffer_, sbeBlockLength());
    return true;
}


bool Sbe<xsl:value-of select="@name"/>::parseFromData(const char* buffer, int len)
{
    NTS_ASSERT(sbeBlockLength() &lt;= MAX_ENTITY_SIZE);
    if (buffer == NULL || len != sbeBlockLength()){
        return false;
    }
    memcpy(buffer_, buffer, sbeBlockLength());
    return true;
}

Sbe<xsl:value-of select="@name"/>::Sbe<xsl:value-of select="@name"/>(const Sbe<xsl:value-of select="@name"/>&amp; other)
{
    if (&amp;other == this)
        return;
    _fieldID = TF_FID_<xsl:value-of select="@name"/>;
    wrapForEncode(buffer_, 0, sbeBlockLength());
    parseFromData(other.buffer_, sbeBlockLength());
}

Sbe<xsl:value-of select="@name"/>&amp; Sbe<xsl:value-of select="@name"/>::operator =(const Sbe<xsl:value-of select="@name"/>&amp; other)
{
    if (this == &amp;other)
        return *this;
    _fieldID = TF_FID_<xsl:value-of select="@name"/>;
    wrapForEncode(buffer_, 0, sbeBlockLength());
    parseFromData(other.buffer_, sbeBlockLength());
    return *this;
}
    </xsl:for-each>


  </xsl:template>
  
</xsl:stylesheet>