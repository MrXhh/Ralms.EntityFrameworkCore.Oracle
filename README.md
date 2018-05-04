# Ralms.EntityFrameworkCore.Oracle

Ralms.EntityFrameworkCore.Oracle is a community developed fork of Provier of Sample Microsoft.EntityFrameworkCore.Oracle.
 

## Running the tests

Original information [here](https://github.com/aspnet/EntityFrameworkCore/tree/dev/samples/OracleProvider)

1) Install [Oracle Database 12c Release 2 (12.2.0.1.0) - Standard Edition 2](http://www.oracle.com/technetwork/database/enterprise-edition/downloads/index.html)
    - When installing, ensure to enable pluggable databases - the sample relies on a specific pluggable database.

2) Use a shell to connect via SQLPlus:

    ```
    > sqlplus / as sysdba
    ```

3) Create a pluggable database used to host the EF test databases:

    ```
       CREATE PLUGGABLE DATABASE ef
       ADMIN USER ef_pdb_admin IDENTIFIED BY ef_pdb_admin
       ROLES = (DBA)
       FILE_NAME_CONVERT = ('\pdbseed\', '\pdb_ef\');
    ```

4) Open the pluggable database:

    ```
       ALTER PLUGGABLE DATABASE ef OPEN;
    ```
