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

using System.Data.Common;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Oracle.ManagedDataAccess.Client;

namespace Ralms.EntityFrameworkCore.Oracle.Storage.Internal
{
    public class OracleRelationalConnection : RelationalConnection, IOracleConnection
    {
        public const string EFPDBAdminUser = "ef_pdb_admin";

        internal const int DefaultMasterConnectionCommandTimeout = 60;

        public OracleRelationalConnection([NotNull] RelationalConnectionDependencies dependencies)
            : base(dependencies)
        {
        }

        protected override DbConnection CreateDbConnection() => new OracleConnection(ConnectionString);

        public override bool IsMultipleActiveResultSetsEnabled => true;

        public virtual IOracleConnection CreateMasterConnection()
        {
            var connectionStringBuilder
                = new OracleConnectionStringBuilder(ConnectionString)
                {
                    UserID = EFPDBAdminUser,
                    Password = EFPDBAdminUser
                };

            var contextOptions = new DbContextOptionsBuilder()
                .UseOracle(
                    connectionStringBuilder.ConnectionString,
                    b => b.CommandTimeout(CommandTimeout ?? DefaultMasterConnectionCommandTimeout))
                .Options;

            return new OracleRelationalConnection(Dependencies.With(contextOptions));
        }
    }
}
