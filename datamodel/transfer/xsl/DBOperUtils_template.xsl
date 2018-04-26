<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="/">
#pragma once

#include "base/Public.h"
#include &lt;stdio.h&gt;
#include &lt;string.h&gt;
#include "database/MySQLDB.h"
#include "sbebiz/SbeEntity.h"

_TFZQ_STP_APP_NS_BEGIN_
_USING_TFZQ_MYSQL_NS_
class CDBOperUtils
{
public:
      <xsl:for-each select="/EntityModel/Entities/Entity">  <!--[@dbTable='yes']-->
     ///SQL Function for <xsl:value-of select="@name"/>
     static string buildInsertSql(<xsl:value-of select="@name"/>_In *p<xsl:value-of select="@name"/>, bool replace = false, const char *table = nullptr);
     static string buildUpdateSql(<xsl:value-of select="@name"/>_In *p<xsl:value-of select="@name"/>, const char *where = NULL, const char *table = nullptr);
     static string buildDeleteSql(<xsl:value-of select="@name"/>_In *p<xsl:value-of select="@name"/>, const char *where = NULL, const char *table = nullptr);
     static bool selectResult(CMySQLDb *pDbCon, const char *selectSql, vector&lt;Sbe<xsl:value-of select="@name"/>&gt; &amp;result);
      </xsl:for-each>
};

/////////////////////////////////////////////////////////////////////////
///SQL Function Impl
///////////////////////////////////////////////////////////////////////// 

      <xsl:for-each select="/EntityModel/Entities/Entity"> 
        <xsl:variable name="entityname" select="@name" />
        <!--insert sql template head -->
inline string CDBOperUtils::buildInsertSql(<xsl:value-of select="@name"/>_In *p<xsl:value-of select="@name"/>, bool replace, const char *table)
{
    if (p<xsl:value-of select="@name"/> == NULL)
        return "";
    string sql = "";
    stringstream  field ;
    stringstream  value ;
    value &lt;&lt; std::fixed;
       
        <xsl:for-each select="Field">
          <xsl:variable name="name" select="@name" />
          <xsl:variable name="position" select="position()" />
          <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
                  <xsl:choose>
                    <xsl:when test="@type='EnumChar'">
    if (p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>() != 0)
    {
                              <xsl:if test="$position != 1">
        field &lt;&lt; " , ";
        value &lt;&lt; " , ";<no_new_line />
                        </xsl:if>   
        char temp = p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>();
        field &lt;&lt; "<xsl:value-of select="@name"/>" ;
        value &lt;&lt; "'" &lt;&lt; string(&amp;temp, 1) &lt;&lt; "'";                   
    }
                    </xsl:when>
                    <xsl:when test="@type='Bool'">
    if (p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>() != 0)
    {
                      <xsl:if test="$position != 1">
           field &lt;&lt; " , ";
           value &lt;&lt; " , ";<no_new_line />
                        </xsl:if>  
           field &lt;&lt;  "<xsl:value-of select="@name"/>" ;
           value &lt;&lt;  1;
                   
    } else {
                      <xsl:if test="$position != 1">
           field &lt;&lt; " , ";
           value &lt;&lt; " , ";<no_new_line />
                        </xsl:if>  
           field &lt;&lt;  "<xsl:value-of select="@name"/>" ;
           value &lt;&lt;  0;       
    }
                    </xsl:when>
                    <xsl:when test="@type='String' or @type='Date' or @type='Time'">
    if (strlen(p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>()) != 0)
    {
                         <xsl:if test="$position != 1">
        field &lt;&lt; " , ";
        value &lt;&lt; " , ";<no_new_line />
                        </xsl:if>  
        field &lt;&lt; "<xsl:value-of select="@name"/>" ;
        value &lt;&lt; "'" &lt;&lt; string(p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>()) &lt;&lt; "'"; 
    }
                    </xsl:when>
                    <xsl:otherwise>
                     <xsl:if test="$position != 1">
    field &lt;&lt; " , ";
    value &lt;&lt; " , ";
                      </xsl:if>
    field &lt;&lt;  "<xsl:value-of select="@name"/>" ;
    value &lt;&lt;  p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>();
                    </xsl:otherwise>
                  </xsl:choose>
          </xsl:for-each>
        </xsl:for-each>     
    string tableName = table == nullptr ? "<xsl:value-of select="$entityname"/>" : table;
        if (replace){
        sql += ("replace into `" + tableName + "` (" + field.str() + ") values (" + value.str() + ")");
        }
        else {
        sql += ("insert into `" + tableName + "` (" + field.str() + ") values (" + value.str() + ")");
        }
        return sql;
        }

        inline string CDBOperUtils::buildUpdateSql(<xsl:value-of select="$entityname"/>_In *p<xsl:value-of select="$entityname"/>, const char *where, const char *table)
{
    if (p<xsl:value-of select="$entityname"/> == NULL)
        return "";
    string sql = "";
    stringstream  field;
    field &lt;&lt; std::fixed;
        <xsl:for-each select="Field">
          <xsl:variable name="name" select="@name" />
          <xsl:variable name="position" select="position()" />
          <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
     
                  <xsl:choose>
                    <xsl:when test="@type='EnumChar'">
    if (p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>() != 0)
    {
                         <xsl:if test="$position != 1">
        field &lt;&lt; " , "; <no_new_line />
                        </xsl:if>
        char temp = p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>();
        field &lt;&lt; "<xsl:value-of select="@name"/>=" &lt;&lt; "'" &lt;&lt; string(&amp;temp, 1) &lt;&lt; "'"; <no_new_line />

    }<no_new_line />
                    </xsl:when>
                    <xsl:when test="@type='Bool'">
    if (p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>() != 0)
    {
                        <xsl:if test="$position != 1">
        field &lt;&lt; " , "; <no_new_line />
                        </xsl:if>
        field &lt;&lt;"<xsl:value-of select="@name"/>=" &lt;&lt; 1 ;<no_new_line />
    } else {
                        <xsl:if test="$position != 1">
        field &lt;&lt; " , "; <no_new_line />
                        </xsl:if>
        field &lt;&lt;"<xsl:value-of select="@name"/>=" &lt;&lt; 0 ;<no_new_line />                   
    }<no_new_line />
                    </xsl:when>
                    <xsl:when test="@type='String' or @type='Date' or @type='Time'">
    if (strlen(p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>()) != 0)
    {
                         <xsl:if test="$position != 1">
        field &lt;&lt; " , "; <no_new_line />
                        </xsl:if>
        field &lt;&lt;"<xsl:value-of select="@name"/>="  &lt;&lt; "'"  &lt;&lt; string(p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>())  &lt;&lt; "'"; <no_new_line />
    }<no_new_line />
                    </xsl:when>
                    <xsl:otherwise>
                        <xsl:if test="$position != 1">
        field &lt;&lt; " , "; <no_new_line />
                        </xsl:if>
    field &lt;&lt;"<xsl:value-of select="@name"/>=" &lt;&lt; p<xsl:value-of select="$entityname"/>-><xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>(); <no_new_line />
                    </xsl:otherwise>
                  </xsl:choose>
          </xsl:for-each>
        </xsl:for-each>
    string tableName = table == nullptr ? "<xsl:value-of select="$entityname"/>" : table;
        sql += "update `" + tableName + "` set " + field.str();
        if (where != NULL &amp;&amp; strlen(where) != 0)
    {
        sql += " where " + string(where);
    }
    return sql;
}      

inline string CDBOperUtils::buildDeleteSql(<xsl:value-of select="$entityname"/>_In *p<xsl:value-of select="$entityname"/>, const char *where, const char *table)
{
    if (p<xsl:value-of select="$entityname"/> == NULL)
        return "";
    string tableName = table == nullptr ? "<xsl:value-of select="$entityname"/>" : table;

        string sql = "delete from `" + tableName + "`";

        if (where != NULL &amp;&amp; strlen(where) != 0)
    {
        sql += " where " + string(where);
    }
    return sql;
}

inline bool CDBOperUtils::selectResult(CMySQLDb *pDbCon, const char *selectSql, vector&lt;Sbe<xsl:value-of select="$entityname"/>&gt; &amp;result)
{
    try
    {
        if (pDbCon == NULL || pDbCon->ping() != 0){
            return false;
        }
        if (selectSql == NULL || strlen(selectSql) == 0){
            return false;
        }
        CMySQLQuery query = pDbCon->execQuery(selectSql);
        //int rowCount = query.getRowNum();
        int fieldCount = query.getFieldsNum();
        while (!query.eof())
        {
            Sbe<xsl:value-of select="$entityname"/> obj;
            
            for (int i = 0; i &lt; fieldCount; i++)
            {
                const char* field = query.getStringField(i);
                const char *fieldName = query.getFieldName(i);         
          <xsl:for-each select="Field">
            <xsl:variable name="name" select="@name" />
            <xsl:variable name="last" select="last()" />
            <xsl:variable name="position" select="position()" />
            <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
                if (strcasecmp("<xsl:value-of select="@name"/>", fieldName) == 0){
                    if (field != NULL) <no_new_line />
                    <xsl:choose>
                      <xsl:when test="@type='EnumChar'">
                        obj.<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>(*field);<no_new_line />
                      </xsl:when>
                      <xsl:when test="@type='String' or @type='Date' or @type='Time'">
                        obj.put<xsl:value-of select="@name"/>(field);<no_new_line />
                      </xsl:when>
                      <xsl:when test="@type='Double'">
                        obj.<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>(atof(field));<no_new_line />
                      </xsl:when>
                      <xsl:when test="@type='Int'">
                        obj.<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>(atoi(field));<no_new_line />
                      </xsl:when>
                      <xsl:when test="@type='Bool'">
                        obj.<xsl:value-of select="translate(substring($name,1,1),$uppercase, $lowercase)"/><xsl:value-of select="substring($name,2)"/>(atoi(field) ? true : false);<no_new_line />
                      </xsl:when>
                      <xsl:otherwise>
                        <xsl:message>
                          unknown filed type  <xsl:value-of select="@type"/>
                        </xsl:message>
                      </xsl:otherwise>
                    </xsl:choose>
                    continue;
                }
            </xsl:for-each>
          </xsl:for-each>
            }
            result.push_back(obj);
            query.nextRow();
        }
    }
    catch (SQLException &amp;e)
    {
    	std::cerr &lt;&lt; e.what() &lt;&lt; std::endl;
    	throw;
    }
    catch (...)
    {
    	throw;
    }
    return true;
}
      </xsl:for-each>
_TFZQ_STP_APP_NS_END_
  </xsl:template>
</xsl:stylesheet>