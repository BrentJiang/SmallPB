<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="/">
<![CDATA[#pragma once

#ifndef ERROR_DEFINE_H
#define ERROR_DEFINE_H

#include <map>
#include <string>
#include "model/AppNs.h"]]>

_TFZQ_STP_APP_NS_BEGIN_

    <xsl:for-each select="errors/error">
const int ERR_TF_<xsl:value-of select="@id"/> = <xsl:value-of select="@value"/>; ///<xsl:value-of select="@prompt"/>
    </xsl:for-each>
    
<![CDATA[
class ErrorDefine
{
public:
	
	static bool getErrorMessage(int errorID, std::string &errorMsg);
	const static std::map<int, std::string>& getErrorMap();
  static std::string getErrorMessage(int errorID);

private:
	const static std::map<int, std::string> errorMap;
};

_TFZQ_STP_APP_NS_END_

#endif
]]>

  </xsl:template>
</xsl:stylesheet>