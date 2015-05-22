// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text;
using Microsoft.AspNet.Razor.Generator;
using Microsoft.AspNet.Razor.Generator.Compiler;
using Microsoft.AspNet.Razor.Generator.Compiler.CSharp;
using Microsoft.Framework.Internal;

namespace Microsoft.AspNet.Mvc.Razor
{
    public abstract class MvcCSharpCodeVisitor : MvcCSharpChunkVisitor
    {
        public MvcCSharpCodeVisitor([NotNull] CSharpCodeWriter writer,
                                    [NotNull] CodeBuilderContext context)
            : base(writer, context)
        {
        }
        
        protected override void Visit(InjectChunk chunk)
        {
        }
        protected override void Visit(ModelChunk chunk)
        {
        }
    }
}