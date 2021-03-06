﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.QuickInject
{
    using System.Runtime.CompilerServices;

    public sealed class TransientLifetimeManager : LifetimeManager
    {
        internal static TransientLifetimeManager Default { get; } = new TransientLifetimeManager();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override object GetValue()
        {
            return null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override object GetValue(object resolutionContext)
        {
            return this.GetValue();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void SetValue(object newValue)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void SetValue(object resolutionContext, object newValue)
        {
        }

        public override void RemoveValue()
        {
        }

        public override void RemoveValue(object resolutionContext)
        {
        }
    }
}