using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
using WinFormsApp1;

namespace Tests
{
    [TestFixture]
    public class MainFormTests
    {
        [Test]
        public void TestIntersectsWithRectangle()
        {
            var segment = new Segment(new Point(0, 0), new Point(10, 10));
            var rectangle = new RectangleF(5, 5, 10, 10);
            ClassicAssert.IsTrue(segment.IntersectsWith(rectangle));
        }

        [Test]
        public void TestNotIntersectsWithRectangle()
        {
            var segment = new Segment(new Point(0, 0), new Point(10, 10));
            var rectangle = new RectangleF(20, 20, 10, 10);
            ClassicAssert.IsFalse(segment.IntersectsWith(rectangle));
        }
    }
}
