﻿using System;
using System.Collections.Generic;
using System.Text;

using SharpGLTF.SchemaReflection;

namespace SharpGLTF
{
    class IorExtension : SchemaProcessor
    {
        private static string SchemaUri => Constants.KhronosExtensionPath("KHR_materials_ior", "glTF.KHR_materials_ior.schema.json");
        public override IEnumerable<(string, SchemaType.Context)> Process()
        {
            var ctx = SchemaProcessing.LoadSchemaContext(SchemaUri);
            ctx.IgnoredByCodeEmitter("glTF Property");
            ctx.IgnoredByCodeEmitter("glTF Child of Root Property");
            // ctx.IgnoredByCodeEmitter("Texture Info");
            // ctx.IgnoredByCodeEmitter("Material Normal Texture Info");

            yield return ("ext.Ior.g", ctx);
        }

        public override void PrepareTypes(CodeGen.CSharpEmitter newEmitter, SchemaType.Context ctx)
        {
            newEmitter.SetRuntimeName("KHR_materials_ior glTF extension", "MaterialIOR");
        }
    }
}
