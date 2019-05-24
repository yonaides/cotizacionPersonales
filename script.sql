IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE TABLE [Clientes] (
        [ClienteID] int NOT NULL IDENTITY,
        [NombreCliente] nvarchar(max) NOT NULL,
        [TelefonoCliente] nvarchar(max) NULL,
        [DireccionCliente] nvarchar(max) NULL,
        [EmailCliente] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Clientes] PRIMARY KEY ([ClienteID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE TABLE [Servicio] (
        [ServicioID] int NOT NULL IDENTITY,
        [NombreServicio] nvarchar(max) NOT NULL,
        [DescripcionServicio] nvarchar(max) NULL,
        [PrecioServicio] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_Servicio] PRIMARY KEY ([ServicioID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE TABLE [Cotizacion] (
        [CotizacionID] int NOT NULL IDENTITY,
        [ClienteID] int NULL,
        [FechaCotizacion] datetime2 NOT NULL,
        [MontoTotal] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_Cotizacion] PRIMARY KEY ([CotizacionID]),
        CONSTRAINT [FK_Cotizacion_Clientes_ClienteID] FOREIGN KEY ([ClienteID]) REFERENCES [Clientes] ([ClienteID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE TABLE [ServicioDetalle] (
        [ServicioDetalleID] int NOT NULL IDENTITY,
        [ServicioID] int NOT NULL,
        [DescripcionDetalleServicio] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_ServicioDetalle] PRIMARY KEY ([ServicioDetalleID]),
        CONSTRAINT [FK_ServicioDetalle_Servicio_ServicioID] FOREIGN KEY ([ServicioID]) REFERENCES [Servicio] ([ServicioID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE TABLE [CotizacionDetalle] (
        [CotizacionDetalleID] int NOT NULL IDENTITY,
        [CotizacionID] int NOT NULL,
        [ServicioID] int NOT NULL,
        [FechaCotizacion] datetime2 NOT NULL,
        [precioServicio] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_CotizacionDetalle] PRIMARY KEY ([CotizacionDetalleID]),
        CONSTRAINT [FK_CotizacionDetalle_Cotizacion_CotizacionID] FOREIGN KEY ([CotizacionID]) REFERENCES [Cotizacion] ([CotizacionID]) ON DELETE CASCADE,
        CONSTRAINT [FK_CotizacionDetalle_Servicio_ServicioID] FOREIGN KEY ([ServicioID]) REFERENCES [Servicio] ([ServicioID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ClienteID', N'DireccionCliente', N'EmailCliente', N'NombreCliente', N'TelefonoCliente') AND [object_id] = OBJECT_ID(N'[Clientes]'))
        SET IDENTITY_INSERT [Clientes] ON;
    INSERT INTO [Clientes] ([ClienteID], [DireccionCliente], [EmailCliente], [NombreCliente], [TelefonoCliente])
    VALUES (1, N'Santiago de los Caballeros', N'yonaides@gmail.com', N'Yonaides Tavares', N'829-883-6835');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ClienteID', N'DireccionCliente', N'EmailCliente', N'NombreCliente', N'TelefonoCliente') AND [object_id] = OBJECT_ID(N'[Clientes]'))
        SET IDENTITY_INSERT [Clientes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE INDEX [IX_Cotizacion_ClienteID] ON [Cotizacion] ([ClienteID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE INDEX [IX_CotizacionDetalle_CotizacionID] ON [CotizacionDetalle] ([CotizacionID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE INDEX [IX_CotizacionDetalle_ServicioID] ON [CotizacionDetalle] ([ServicioID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    CREATE INDEX [IX_ServicioDetalle_ServicioID] ON [ServicioDetalle] ([ServicioID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190524001320_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190524001320_InitialCreate', N'2.2.4-servicing-10062');
END;

GO

