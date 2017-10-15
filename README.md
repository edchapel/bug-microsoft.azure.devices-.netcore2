### Unable to use the Azure IoT Hub `RegistryManager` to get or update Twin data from .NET Core 2.

For a new .NET Core 2 console application, using `RegistryManager.GetTwinAsync("")` or `RegistryManager.UpdateTwinAsync("")` results in a build error.

Steps to reproduce:

1. Create new .NET Core 2 console application
1. Install 'Microsoft.Azure.Devices' NuGet package (v1.4.0)
1. Add usage of `RegistryManager.GetTwinAsync("")` or `RegistryManager.UpdateTwinAsync("")`.

```
using System;

using Microsoft.Azure.Devices;

namespace IoTHubService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var manager = RegistryManager.CreateFromConnectionString("");
            var twin = manager.GetTwinAsync("").Result;
        }
    }
}
```


The solution now fails to compile with the error:

`Error CS0012: The type 'Twin' is defined in an assembly that is not referenced. You must add a reference to assembly 'Microsoft.Azure.Devices.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'.`