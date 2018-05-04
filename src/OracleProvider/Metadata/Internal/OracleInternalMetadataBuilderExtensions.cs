/* This project came from a fork of: https://github.com/aspnet/EntityFrameworkCore
 * Copyright (c) .NET Foundation. All rights reserved.
 * Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
 * 
 *          Copyright (c)  2018 Rafael Almeida (ralms@ralms.net)
 *
 *                    Ralms.EntityFrameworkCore.Oracle
 *
 * THIS MATERIAL IS PROVIDED AS IS, WITH ABSOLUTELY NO WARRANTY EXPRESSED
 * OR IMPLIED.  ANY USE IS AT YOUR OWN RISK.
 *
 * Permission is hereby granted to use or copy this program
 * for any purpose,  provided the above notices are retained on all copies.
 * Permission to modify the code and to distribute modified code is granted,
 * provided the above notices are retained, and a notice that the code was
 * modified is included with the above copyright notice.
 *
 */

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ralms.EntityFrameworkCore.Oracle.Metadata.Internal
{
    public static class OracleInternalMetadataBuilderExtensions
    {
        public static OracleModelBuilderAnnotations Oracle(
            [NotNull] this InternalModelBuilder builder,
            ConfigurationSource configurationSource)
            => new OracleModelBuilderAnnotations(builder, configurationSource);

        public static OraclePropertyBuilderAnnotations Oracle(
            [NotNull] this InternalPropertyBuilder builder,
            ConfigurationSource configurationSource)
            => new OraclePropertyBuilderAnnotations(builder, configurationSource);

        public static OracleEntityTypeBuilderAnnotations Oracle(
            [NotNull] this InternalEntityTypeBuilder builder,
            ConfigurationSource configurationSource)
            => new OracleEntityTypeBuilderAnnotations(builder, configurationSource);

        public static OracleKeyBuilderAnnotations Oracle(
            [NotNull] this InternalKeyBuilder builder,
            ConfigurationSource configurationSource)
            => new OracleKeyBuilderAnnotations(builder, configurationSource);

        public static OracleIndexBuilderAnnotations Oracle(
            [NotNull] this InternalIndexBuilder builder,
            ConfigurationSource configurationSource)
            => new OracleIndexBuilderAnnotations(builder, configurationSource);

        public static RelationalForeignKeyBuilderAnnotations Oracle(
            [NotNull] this InternalRelationshipBuilder builder,
            ConfigurationSource configurationSource)
            => new RelationalForeignKeyBuilderAnnotations(builder, configurationSource);
    }
}
