﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class MagickImageTests
    {
        public class TheThumbnailMethod
        {
            [Fact]
            public void ShouldThrowExceptionWhenGeometryIsNull()
            {
                using (var image = new MagickImage())
                {
                    Assert.Throws<ArgumentNullException>("geometry", () =>
                    {
                        image.Thumbnail(null);
                    });
                }
            }

            [Fact]
            public void ShouldThrowExceptionWhenPercentageWidthIsNegative()
            {
                using (var image = new MagickImage())
                {
                    Assert.Throws<ArgumentException>("percentageWidth", () =>
                    {
                        image.Thumbnail(new Percentage(-1), new Percentage(1));
                    });
                }
            }

            [Fact]
            public void ShouldThrowExceptionWhenPercentageHeightIsNegative()
            {
                using (var image = new MagickImage())
                {
                    Assert.Throws<ArgumentException>("percentageHeight", () =>
                    {
                        image.Thumbnail(new Percentage(1), new Percentage(-1));
                    });
                }
            }

            [Fact]
            public void ShouldCreateThumbnailOfTheImage()
            {
                using (var image = new MagickImage(Files.SnakewarePNG))
                {
                    image.Thumbnail(100, 100);
                    Assert.Equal(100, image.Width);
                    Assert.Equal(23, image.Height);
                }
            }

            [Fact]
            public void ShouldCreateThumbnailOfTheImageWithTheSpecifiedPercentage()
            {
                using (var image = new MagickImage(Files.Builtin.Logo))
                {
                    image.Thumbnail(new Percentage(50));
                    Assert.Equal(320, image.Width);
                    Assert.Equal(240, image.Height);
                }
            }
        }
    }
}
