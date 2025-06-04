using System.Collections.Generic;
using ECommerceApi.Data;
using ECommerceApi.GraphQL.Types.Orders.Util;
using Xunit;

namespace ECommerceApi.Tests.GraphQL.Types.Orders.Util
{
    public class OrderUtilTests
    {
        [Fact]
        public void CalculateTotalPrice_SumsSubtotalPriceTimesQuantity()
        {
            // Arrange
            var details = new List<OrderDetail>
            {
                new OrderDetail { Quantity = 2, SubtotalPrice = 10m },
                new OrderDetail { Quantity = 3, SubtotalPrice = 5m },
                new OrderDetail { Quantity = 1, SubtotalPrice = 20m }
            };

            // Act
            var result = OrderUtil.CalculateTotalPrice(details);

            // Assert
            var expected = 2 * 10m + 3 * 5m + 1 * 20m;
            Assert.Equal(expected, result);
        }
    }
}
