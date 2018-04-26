<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>


  <xsl:template match="/">
#pragma once

#ifndef TF_DATA_STRUCT_H
#define TF_DATA_STRUCT_H

#include "string.h"
#include "TFDataType.h"

namespace tfzq{ namespace stp{
 
    <xsl:for-each select="/EntityModel/Entities/Entity">
///<xsl:value-of select="@title"/>
struct TF<xsl:value-of select="@name"/>Field
{<no_new_line />
      <xsl:for-each select="Field">
        <xsl:variable name="name" select="@name"/>
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:if test="position()=last()">
<xsl:choose>
  <xsl:when test="@type='String'">
    ///<xsl:value-of select="@label"/>
    char <xsl:value-of select="@name"/>[TF_<xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>_LEN]; <no_new_line />
  </xsl:when>
  <xsl:when test="@type='Int'">
    ///<xsl:value-of select="@label"/>
    int <xsl:value-of select="@name"/>;<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Double'">
    ///<xsl:value-of select="@label"/>
    double <xsl:value-of select="@name"/>;<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Date'">
    ///<xsl:value-of select="@label"/>
    char <xsl:value-of select="@name"/>[TF_DATE_LEN];<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Time'">
    ///<xsl:value-of select="@label"/>
    char <xsl:value-of select="@name"/>[TF_TIME_LEN];<no_new_line />
  </xsl:when>
  <xsl:when test="@type='Bool'">
    ///<xsl:value-of select="@label"/>
    bool <xsl:value-of select="@name"/>;<no_new_line />
  </xsl:when>
  <xsl:when test="@type='EnumChar'">
    ///<xsl:value-of select="@label"/>
    char <xsl:value-of select="@name"/>;<no_new_line />
  </xsl:when>
  <xsl:otherwise>
    <xsl:message>
      TYPE DOES NOT EXIST![<xsl:value-of select="@type"/>]
    </xsl:message>
  </xsl:otherwise>
</xsl:choose>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
      
    ///initialized to zero
    TF<xsl:value-of select="@name"/>Field(){
        memset(this, 0 , sizeof(TF<xsl:value-of select="@name"/>Field));
    }
};
    </xsl:for-each>
}}
#endif
  </xsl:template>
</xsl:stylesheet>