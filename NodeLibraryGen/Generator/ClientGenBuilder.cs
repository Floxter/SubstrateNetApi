﻿using SubstrateNetApi;
using SubstrateNetApi.Model.Meta;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace RuntimeMetadata
{
    partial class Program
    {
        public class ClientGenBuilder : ClientBuilder
        {
            private ClientGenBuilder(uint id, List<(string, List<string>)> moduleNames, Dictionary<uint, (string, List<string>)> typeDict) :
                base(id, moduleNames, typeDict)
            {
            }

            public static ClientGenBuilder Init(uint id, List<(string, List<string>)> moduleNames, Dictionary<uint, (string, List<string>)> typeDict)
            {
                return new ClientGenBuilder(id, moduleNames, typeDict);
            }

            public override ClientGenBuilder Create()
            {
                #region CREATE
 
                ClassName = "SubstrateClientExt";
                NameSpace = "SubstrateNetApi";

                CodeNamespace typeNamespace = new(NameSpace);
                TargetUnit.Namespaces.Add(typeNamespace);

                var targetClass = new CodeTypeDeclaration(ClassName)
                {
                    IsClass = true,
                    TypeAttributes = TypeAttributes.Public | TypeAttributes.Sealed
                };
                targetClass.BaseTypes.Add(new CodeTypeReference(typeof(SubstrateClient)));
                typeNamespace.Types.Add(targetClass);

                CodeConstructor constructor = new()
                {
                    Attributes = MemberAttributes.Public | MemberAttributes.Final
                };

                // Add parameters.
                constructor.Parameters.Add(new CodeParameterDeclarationExpression(
                    typeof(Uri), "uri"));
                constructor.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("uri"));

                targetClass.Members.Add(constructor);

                foreach(var tuple in ModuleNames)
                {
                    var pallets = new string[] { "Storage" }; // , "Call"};

                    foreach (var pallet in pallets)
                    {
                        var name = tuple.Item1.Split('.').Last() + pallet;
                        var referenceName = tuple.Item2[0] + "." + name;

                        CodeMemberField clientField = new()
                        {
                            Attributes = MemberAttributes.Public,
                            Name = name,
                            Type = new CodeTypeReference(referenceName)
                        };
                        clientField.Comments.Add(new CodeCommentStatement($"{name} storage calls."));
                        targetClass.Members.Add(clientField);

                        CodeFieldReferenceExpression fieldReference =
                            new(new CodeThisReferenceExpression(), name);

                        var createPallet = new CodeObjectCreateExpression(referenceName);
                        createPallet.Parameters.Add(new CodeThisReferenceExpression());
                        constructor.Statements.Add(new CodeAssignStatement(fieldReference, createPallet));
                    }
                }



                #endregion

                return this;
            }

        }

    }

}