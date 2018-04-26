<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>


  <xsl:template match="/">
#pragma once

#ifndef TF_DATA_TYPE_H
#define TF_DATA_TYPE_H


enum TF_RESUME_TYPE
{
	TF_TERT_RESTART = 0,
	TF_TERT_RESUME,
	TF_TERT_QUICK
};

    <xsl:for-each select="EntityModel/Fields/Field[@type='EnumChar']">
      <xsl:variable name="prefix" select="@prefix"/>
      
/////////////////////////////////////////////////////////////////////////
///<xsl:value-of select="@name"/>Type是一个<xsl:value-of select="@label"/>类型
/////////////////////////////////////////////////////////////////////////<no_new_line />
      <xsl:for-each select="enum">
///<xsl:value-of select="@label"/>
#define TF_<xsl:value-of select="$prefix"/>_<xsl:value-of select="@name"/>  '<xsl:value-of select="@value"/>' <no_new_line />
      </xsl:for-each>
    </xsl:for-each>

/////////////////////////////////////////////////////////////////////////
///常量定义
/////////////////////////////////////////////////////////////////////////

    <xsl:for-each select="EntityModel/Fields/Field[@type='String']">
///<xsl:value-of select="@label"/>长度的定义
#define TF_<xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>_LEN  (<xsl:value-of select="@length"/> + 1) <no_new_line />
    </xsl:for-each>

#define TF_EXCHANGE_SSE  "SH"
#define TF_EXCHANGE_SZSE  "SZ"
#define TF_EXCHANGE_CFFEX  "CFFEX"
#define TF_EXCHANGE_SHFE  "SHFE"
#define TF_EXCHANGE_DCE  "DCE"
#define TF_EXCHANGE_CZCE  "CZCE"

    #endif
  </xsl:template>
</xsl:stylesheet>