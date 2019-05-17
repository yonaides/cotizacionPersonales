IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE TABLE [clientes] (
        [ClienteID] int NOT NULL IDENTITY,
        [NombreCliente] nvarchar(max) NULL,
        [TelefonoCliente] nvarchar(max) NULL,
        [DireccionCliente] nvarchar(max) NULL,
        [EmailCliente] nvarchar(max) NULL,
        CONSTRAINT [PK_clientes] PRIMARY KEY ([ClienteID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE TABLE [servicio] (
        [ServicioID] int NOT NULL IDENTITY,
        [NombreServicio] nvarchar(max) NULL,
        [DescripcionServicio] nvarchar(max) NULL,
        [PrecioServicio] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_servicio] PRIMARY KEY ([ServicioID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE TABLE [cotizacion] (
        [CotizacionID] int NOT NULL IDENTITY,
        [ClienteID] int NULL,
        [FechaCotizacion] datetime2 NOT NULL,
        [MontoTotal] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_cotizacion] PRIMARY KEY ([CotizacionID]),
        CONSTRAINT [FK_cotizacion_clientes_ClienteID] FOREIGN KEY ([ClienteID]) REFERENCES [clientes] ([ClienteID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE TABLE [servicioDetalle] (
        [ServicioDetalleID] int NOT NULL IDENTITY,
        [ServicioID] int NULL,
        [DescripcionDetalleServicio] nvarchar(max) NULL,
        CONSTRAINT [PK_servicioDetalle] PRIMARY KEY ([ServicioDetalleID]),
        CONSTRAINT [FK_servicioDetalle_servicio_ServicioID] FOREIGN KEY ([ServicioID]) REFERENCES [servicio] ([ServicioID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE TABLE [cotizacionDetalle] (
        [CotizacionDetalleID] int NOT NULL IDENTITY,
        [IdClienteClienteID] int NULL,
        [IdServicioServicioID] int NULL,
        [FechaCotizacion] datetime2 NOT NULL,
        [precioServicio] decimal(18,2) NOT NULL,
        [CotizacionID] int NULL,
        CONSTRAINT [PK_cotizacionDetalle] PRIMARY KEY ([CotizacionDetalleID]),
        CONSTRAINT [FK_cotizacionDetalle_cotizacion_CotizacionID] FOREIGN KEY ([CotizacionID]) REFERENCES [cotizacion] ([CotizacionID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_cotizacionDetalle_clientes_IdClienteClienteID] FOREIGN KEY ([IdClienteClienteID]) REFERENCES [clientes] ([ClienteID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_cotizacionDetalle_servicio_IdServicioServicioID] FOREIGN KEY ([IdServicioServicioID]) REFERENCES [servicio] ([ServicioID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ClienteID', N'DireccionCliente', N'EmailCliente', N'NombreCliente', N'TelefonoCliente') AND [object_id] = OBJECT_ID(N'[clientes]'))
        SET IDENTITY_INSERT [clientes] ON;
    INSERT INTO [clientes] ([ClienteID], [DireccionCliente], [EmailCliente], [NombreCliente], [TelefonoCliente])
    VALUES (1, N'Santiago de los Caballeros', N'yonaides@gmail.com', N'Yonaides Tavares', NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ClienteID', N'DireccionCliente', N'EmailCliente', N'NombreCliente', N'TelefonoCliente') AND [object_id] = OBJECT_ID(N'[clientes]'))
        SET IDENTITY_INSERT [clientes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE INDEX [IX_cotizacion_ClienteID] ON [cotizacion] ([ClienteID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE INDEX [IX_cotizacionDetalle_CotizacionID] ON [cotizacionDetalle] ([CotizacionID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE INDEX [IX_cotizacionDetalle_IdClienteClienteID] ON [cotizacionDetalle] ([IdClienteClienteID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE INDEX [IX_cotizacionDetalle_IdServicioServicioID] ON [cotizacionDetalle] ([IdServicioServicioID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    CREATE INDEX [IX_servicioDetalle_ServicioID] ON [servicioDetalle] ([ServicioID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182609_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190514182609_InitialCreate', N'2.2.4-servicing-10062');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190514182820_ClienteSeedData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190514182820_ClienteSeedData', N'2.2.4-servicing-10062');
END;

GO

