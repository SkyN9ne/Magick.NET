﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick;

namespace Magick.NET.Tests
{
    internal static class TestRuntime
    {
        public static bool HasFlakyLinuxArm64Result
            => Runtime.IsLinux && Runtime.IsArm64;
    }
}
