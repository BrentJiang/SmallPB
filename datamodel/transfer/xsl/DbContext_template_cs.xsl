<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>


  <xsl:template match="/">
using System;
using Microsoft.EntityFrameworkCore;
using SmallPB.entitymodel;

namespace SmallPB.database
{<no_new_line />
    public class TradeContext : DbContext
    {
        public TradeContext(DbContextOptions&lt;TradeContext&gt; options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    <xsl:for-each select="/EntityModel/Entities/Entity"><no_new_line />
      <xsl:if test="@dbTable='yes'">
        <xsl:variable name="name" select="@name"/>
        <xsl:variable name="keynum" select="Field[@iskey='yes']" />
        <xsl:if test="count($keynum)>0">
            /// total <xsl:value-of select="count($keynum)"/> key-elements
            modelBuilder.Entity&lt;Stp<xsl:value-of select="$name"/>&gt;().HasIndex(b => new {<no_new_line />
        </xsl:if>
        <xsl:for-each select="Field">
          <xsl:if test="@iskey='yes'">
                b.<xsl:value-of select="@name"/>,<no_new_line />
          </xsl:if>
        </xsl:for-each>
        <xsl:if test="count($keynum)>0">
            }).IsUnique(true);
        </xsl:if>
      </xsl:if>
    </xsl:for-each>
        }

    <xsl:for-each select="/EntityModel/Entities/Entity"><no_new_line />
      <xsl:if test="@dbTable='yes'">
        public DbSet&lt;Stp<xsl:value-of select="@name"/>&gt; <xsl:value-of select="@name"/>s { get; set; }
      </xsl:if>
    </xsl:for-each>
    }
<![CDATA[
    /// <summary>
    /// A factory to create an instance of the StudentsContext 
    /// </summary>
    public static class ContextFactory
    {
        public static TradeContext Create(string connectionString)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<TradeContext>();
                optionsBuilder.UseSqlite(connectionString);

                // Ensure that the SQLite database and sechema is created!
                var context = new TradeContext(optionsBuilder.Options);
                context.Database.EnsureCreated();

                return context;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
]]>
}
  </xsl:template>
</xsl:stylesheet>