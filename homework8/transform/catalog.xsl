<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">


<html>
<body>
<h2> Order List</h2>
<table border="1">
    <tr bgcolor="#9acd32">
	  <th style="text-align:left">OrderNumber</th>
	  <th style="text-align:left">customerName</th>
      <th style="text-align:left">phoneNum</th>
	  <th style="text-align:left">orderTotalPrice</th>
	</tr>
	 <xsl:for-each select="Order">
	 <tr>
	 <td><xsl:value-of select="orderNumber"/></td>
	 <td><xsl:value-of select="customerName"/></td>
	 <td><xsl:value-of select="phoneNum"/></td>
	 <td><xsl:value-of select="orderTotalPrice"/></td>
	 </tr>
	 <tr bgcolor="#9acd32">
	 
	  <th style="text-align:left">GoodName</th>
	  <th style="text-align:left">price</th>
	   <th style="text-align:left">numberOfGoods</th>
	  <th style="text-align:left">totalPrice</th>
	 
	  </tr>
	  <xsl:for-each select="Order/OrderDetails">
	  <tr>
	 <td><xsl:value-of select="GoodName"/></td>
	 <td><xsl:value-of select="price"/></td>
	 <td><xsl:value-of select="numberOfGoods"/></td>
	 <td><xsl:value-of select="totalPrice"/></td>
	 </tr>
	 </xsl:for-each>
	 </xsl:for-each>
	 </table>
	 </table>
</html>
</xsl:stylesheet>