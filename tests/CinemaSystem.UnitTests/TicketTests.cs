namespace CinemaSystem.UnitTests
{
    using FluentAssertions;
    using System;
    using Xunit;

    public class TicketTests
    {
        [Fact]
        public void BookTicket_BeforeDisplay_ReturnsTicket()
        {
            var result = "code";

            result.Should().NotBeNull();
        }

        [Fact]
        public void BookTicket_AfterDisplayBeforeAdEnds_ReturnsTicket()
        {
            var result = "code";

            result.Should().NotBeNull();
        }

        [Fact]
        public void BookTicket_AfterDisplayAfterAdEnds_ReturnsError()
        {
            var result = "code";

            result.Should().BeNull();
        }

        [Fact]
        public void BookTickets_NearSeats_ReturnsTicket()
        {
            var result = "code";

            result.Should().NotBeNull();
        }

        [Fact]
        public void BookTickets_FarSeats_ReturnsError()
        {
            var result = "code";

            result.Should().BeNull();
        }


        //SEAT FORMAT
        //1 - Occupied
        //0 - Free
        //X - Booked
        //default: 11111111
        [Theory]
        [InlineData("1X1", true)]
        [InlineData("100X1", true)]
        //[InlineData("100X10", true)]
        //[InlineData("1X10", true)]
        [InlineData("10X1", false)]
        public void BookTicket_WithSeatGap(string seatFormat, bool valid)
        {

        }

        [Theory]
        [InlineData("1XX1", true)]
        [InlineData("100XX1", true)]
        //[InlineData("100XX10", true)]
        //[InlineData("1XX10", true)]
        [InlineData("10XX1", false)]
        public void BookTickets_WithSeatGap(string seatFormat, bool valid)
        {
            valid.Should().Be(true);
        }

        //[Fact]
        //public void BookTicket_WithSeatFormat_10X1_ReturnsError()
        //{

        //}

        //[Fact]
        //public void BookTickets_NearOccupiedSeatWithOneGap_ReturnsError()
        //{

        //}

        //[Fact]
        //public void BookTickets_NearOccupiedSeatWithTwoGap_ReturnsError()
        //{

        //}

    }
}