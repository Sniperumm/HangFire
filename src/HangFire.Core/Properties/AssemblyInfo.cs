﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("HangFire")]
[assembly: AssemblyDescription("Core classes of HangFire that are independent of any framework.")]
[assembly: Guid("4deecd4f-19f6-426b-aa87-6cd1a03eaa48")]
[assembly: InternalsVisibleTo("HangFire.Tests")]
[assembly: InternalsVisibleTo("HangFire.Core.Tests")]

// Allow the generation of mocks for internal types
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]