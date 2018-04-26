<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="/">
<![CDATA[#include "ErrorDefine.h"
_USING_TFZQ_STP_APP_NS_
std::pair<int, std::string> pairArray[] = 
{]]><xsl:for-each select="errors/error">
    std::make_pair(ERR_TF_<xsl:value-of select="@id"/>, "<xsl:value-of select="@prompt"/>") <no_new_line />
    <xsl:if test="position() != last()">
      <xsl:text>, </xsl:text>
    </xsl:if>
    </xsl:for-each>
<![CDATA[};
const std::map<int, std::string> ErrorDefine::errorMap(pairArray, pairArray + sizeof(pairArray) / sizeof(pairArray[0]));

bool ErrorDefine::getErrorMessage(int errorID, std::string &errorMsg){
	auto it = errorMap.find(errorID);
	if (it == errorMap.end()){
		return false;
	}
	else {
		errorMsg = it->second;
	}
	return true;
}

const std::map<int, std::string>& ErrorDefine::getErrorMap(){
  return errorMap;
}

std::string ErrorDefine::getErrorMessage(int errorID){
	auto it = errorMap.find(errorID);
	if (it != errorMap.end()){
		return it->second;
	}
	return "";
}

]]>

  </xsl:template>
</xsl:stylesheet>