// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.Versioning;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.JSInterop;

namespace Microsoft.AspNetCore.Components.ProtectedBrowserStorage
{
    /// <summary>
    /// Provides mechanisms for storing and retrieving data in the browser's
    /// 'localStorage' collection.
    ///
    /// This data will be scoped to the current user's browser, shared across
    /// all tabs. The data will persist across browser restarts.
    ///
    /// See: https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage
    /// </summary>
    [UnsupportedOSPlatform("browser")]
    public class ProtectedLocalStorage : ProtectedBrowserStorage
    {
        /// <summary>
        /// Constructs an instance of <see cref="ProtectedLocalStorage"/>.
        /// </summary>
        /// <param name="jsRuntime">The <see cref="IJSRuntime"/>.</param>
        /// <param name="dataProtectionProvider">The <see cref="IDataProtectionProvider"/>.</param>
        public ProtectedLocalStorage(IJSRuntime jsRuntime, IDataProtectionProvider dataProtectionProvider)
            : base("localStorage", jsRuntime, dataProtectionProvider)
        {
        }
    }
}
