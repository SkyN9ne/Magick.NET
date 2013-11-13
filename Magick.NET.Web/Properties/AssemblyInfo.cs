//=================================================================================================
// Copyright 2013 Dirk Lemstra
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;

//=================================================================================================
#if _M_X64
[assembly: AssemblyTitle("Magick.NET.Web x64 net40-client")]
#else
[assembly: AssemblyTitle("Magick.NET.Web x86 net40-client")]
#endif
[assembly: AssemblyProduct("Magick.NET")]
[assembly: AssemblyDescription("Magick.NET.Web")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyCopyright("Copyright � Dirk Lemstra 2013")]
[assembly: AssemblyTrademark("")]
//=================================================================================================
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("6.0.0.0")]
[assembly: AssemblyFileVersion("6.8.7.502")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
//=================================================================================================