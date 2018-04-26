<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>
  <xsl:template match="/"><![CDATA[<?xml version="1.0" encoding="GBK"?>
        <sbe:messageSchema xmlns:sbe="http://fixprotocol.io/2016/sbe"
                   package="tfzq.stp"
                   id="1"
                   version="1"
                   semanticVersion="5.2"
                   description="Example schema with extension"
                   byteOrder="littleEndian">
			<types>
        <type name="cupHolderCount_t" primitiveType="uint8" presence="optional" sinceVersion="1"/>
        <composite name="messageHeader" description="Message identifiers and length of message root">
            <type name="blockLength" primitiveType="uint16"/>
            <type name="templateId" primitiveType="uint16"/>
            <type name="schemaId" primitiveType="uint16"/>
            <type name="version" primitiveType="uint16"/>
        </composite>
        <composite name="groupSizeEncoding" description="Repeating group dimensions">
            <type name="blockLength" primitiveType="uint16"/>
            <type name="numInGroup" primitiveType="uint16"/>
        </composite>
        <composite name="varDataEncoding">
            <type name="length" primitiveType="uint32" maxValue="1073741824"/>
            <type name="varData" primitiveType="uint8" length="0" characterEncoding="GBK"/>
        </composite>
      </types>
]]>
<![CDATA[<types>]]> <nonewline/>
    <xsl:for-each select="EntityModel/Fields/Field[@type='String']">
<![CDATA[   <type name="]]><xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>_TYPE<![CDATA[" primitiveType="char" length="]]><xsl:value-of select="@length+1"/><![CDATA[" characterEncoding="ASCII"/>]]> <nonewline/>
    </xsl:for-each>
<![CDATA[   <type name="DATE_TYPE" primitiveType="char" length="9" characterEncoding="ASCII"/> 
   <type name="TIME_TYPE" primitiveType="char" length="10" characterEncoding="ASCII"/> ]]>
<![CDATA[</types>]]>
    <xsl:for-each select="/EntityModel/Entities/Entity">
      <xsl:variable name="entity_id" select="position()" />
      <![CDATA[<sbe:message name="]]><xsl:value-of select="@name"/>_In<![CDATA[" id="]]><xsl:value-of select="$entity_id"/><![CDATA[" description="]]><xsl:value-of select="@title"/><![CDATA[">]]><no_new_line />
      <xsl:for-each select="Field">
        <xsl:variable name="filed_id" select="position()" />
        <xsl:variable name="name" select="@name"/>
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:if test="position()=last()">
            <xsl:choose>
              <xsl:when test="@type='String'">
                &lt;field name=&quot;<xsl:value-of select="@name"/>&quot; id=&quot;<xsl:value-of select="$filed_id"/>&quot; type=&quot;<xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>_TYPE&quot; /&gt; <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Int'">
                &lt;field name=&quot;<xsl:value-of select="@name"/>&quot; id=&quot;<xsl:value-of select="$filed_id"/>&quot; type=&quot;int32&quot;/&gt; <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Double'">
                &lt;field name=&quot;<xsl:value-of select="@name"/>&quot; id=&quot;<xsl:value-of select="$filed_id"/>&quot; type=&quot;double&quot;/&gt; <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Date'">
                &lt;field name=&quot;<xsl:value-of select="@name"/>&quot; id=&quot;<xsl:value-of select="$filed_id"/>&quot; type=&quot;DATE_TYPE&quot;/&gt; <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Time'">
                &lt;field name=&quot;<xsl:value-of select="@name"/>&quot; id=&quot;<xsl:value-of select="$filed_id"/>&quot; type=&quot;TIME_TYPE&quot;/&gt; <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Bool'">
                &lt;field name=&quot;<xsl:value-of select="@name"/>&quot; id=&quot;<xsl:value-of select="$filed_id"/>&quot; type=&quot;uint8&quot;/&gt; <no_new_line />
              </xsl:when>
              <xsl:when test="@type='EnumChar'">
                &lt;field name=&quot;<xsl:value-of select="@name"/>&quot; id=&quot;<xsl:value-of select="$filed_id"/>&quot; type=&quot;char&quot;/&gt; <no_new_line />
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
      &lt;/sbe:message&gt;
    </xsl:for-each>
 <![CDATA[</sbe:messageSchema>]]>   
    
    
  </xsl:template>
  
</xsl:stylesheet>