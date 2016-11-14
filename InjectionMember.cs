﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace QuickInject
{
    using System.Linq.Expressions;

    public abstract class InjectionMember
    {
        public LambdaExpression Factory { get; protected set; }
    }
}