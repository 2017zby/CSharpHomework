<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <table border="1">
          <tr bgcolor="#FFA54F">
            <th>订单号</th>
            <th>数量</th>
            <th>总价格</th>
            <th>电话</th>
            <th>明细数量</th>
            <th>商品种类</th>
            <th>商品数量</th>
            <th>价格</th>
            <th>总价</th>
          </tr>
          <xsl:for-each select="ArrayOfOrder/Order/orderDetails/OrderDetails">
            <tr>
              <td>
                <xsl:value-of select="../../customerName " />
              </td>
              <td>
                <xsl:value-of select="../../orderNumber" />
              </td>
              <td>
                <xsl:value-of select="../../orderTotalPrice" />
              </td>
              <td>
                <xsl:value-of select="../../phoneNum" />
              </td>
              <td>
                <xsl:value-of select="../../numOfDetails" />
              </td>
              <td>
                <xsl:value-of select="GoodName" />
              </td>
              <td>
                <xsl:value-of select="numberOfGoods" />
              </td>
              <td>
                <xsl:value-of select="price" />
              </td>
              <td>
                <xsl:value-of select="totalPrice" />
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

