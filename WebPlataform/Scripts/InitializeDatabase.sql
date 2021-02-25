USE [WebstoreDb]
GO
--Categorias
INSERT INTO [dbo].[Categories]([Id],[Name],[IsActive],[LastUpdate],[InclusionDate])
VALUES(NEWID(),'Eletronicos',1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO
INSERT INTO [dbo].[Categories]([Id],[Name],[IsActive],[LastUpdate],[InclusionDate])
VALUES(NEWID(),'Computadores',1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO
INSERT INTO [dbo].[Categories]([Id],[Name],[IsActive],[LastUpdate],[InclusionDate])
VALUES(NEWID(),'Animais',1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO
INSERT INTO [dbo].[Categories]([Id],[Name],[IsActive],[LastUpdate],[InclusionDate])
VALUES(NEWID(),'Carros',1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO
INSERT INTO [dbo].[Categories]([Id],[Name],[IsActive],[LastUpdate],[InclusionDate])
VALUES(NEWID(),'Pesca',1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO
--Subcategorias
INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Televisores', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Eletronicos') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Radios', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Eletronicos') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'DVD/Blueray', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Eletronicos') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Maquina de Lavar', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Eletronicos') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Lava Louças', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Eletronicos') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO


INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Notebooks', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Computadores') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Desktops', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Computadores') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Chromebook', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Computadores') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Servidores', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Computadores') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Perifericos', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Computadores') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Rações', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Animais') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Viveiros', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Animais') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Aquarios', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Animais') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Bombas de agua', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Animais') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Filtros', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Animais') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Cabos', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Carros') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Rodas', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Carros') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Pneus', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Carros') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Acessórios', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Carros') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Varas', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Pesca') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Iscas', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Pesca') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Linhas', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Pesca') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO

INSERT INTO [dbo].[Subcategories]([Id],[Name],[CategoryId],[IsActive],[LastUpdate],[InclusionDate])
VALUES (NEWID(),'Carretilha', (SELECT TOP(1) [ID] FROM [dbo].[Categories] WHERE NAME LIKE 'Pesca') ,1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
GO
--Produtos
DECLARE @count INT = 0;

WHILE @count < 60
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Televisão Sansung','Televisão Sansung 42 polegadas','Televisão tela plana 42 polegadas Sansung de otima qualidade',1300.99,'',10,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Televisores'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 40
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Radio lenovo','Radio AM/FM toca CD','Radio a pilha am/fm portatil',25.45,'',2,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Radios'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 100
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Aparelho DVD','Aparelho DVD Sansung','Aparelho DVD Sansung 220',500.00,'',2,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'DVD/Blueray'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 28
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Maquina de Lavar','Maquina de Lavar','Maquina de Lavar brastemp',2500.45,'',2,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Maquina de Lavar'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 3
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Lava Louças','Lava Louças LG','Lava Louças Lg de baixo consumo, otima para apartamentos, 110/220',3000.45,'',2,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Lava Louças'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 200
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'PC Argus','PC Argus','PC argus, produto destinado a programadores',7000.00,'',70,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Desktops'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 30
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Chromebook','PC chroomebook','Pc chroomebook',300.00,'',17,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Chromebook'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 400
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Servidor Dell','Servidor Dell 2TB','Servidor Dell 2TB',4000.00,'',200,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Servidores'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 3000
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'MousePad','MousePad 45 cm','MousePad simples 45 cm',18.00,'',180,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Perifericos'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 15
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Ração para peixe','Ração para lebist','Ração para lebist altamente nutritiva',80.60,'',25,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Rações'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 8
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Gaiola para hamister','Gaiola metalica para hamister','Gaiola metalica para hamister reforçada',350.00,'',7,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Viveiros'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 12
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Aquario de vidro 1000L','Aquario de vidro 1000L com furação para sump','Aquario de vidro 1000L com furação para sump',3000.00,'',3,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Aquarios'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 35
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Bomba de recalque','Bomba de recalque 12mil litros/hora','Bomba de recalque 12mil litros/hora',800.00,'',500,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Bombas de agua'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 25
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Filtro canister','Filtro canister 450L','Filtro canister 450L',450.00,'',20,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Filtros'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 6
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Cabo Freio','Cabo de aço do freio de brasilia','Cabo de aço do freio de brasilia',80.50,'',3,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Cabos'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 9
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Roda Liga leve','Roda Liga leve aro 15','Roda Liga leve aro 15',400.00,'',8,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Rodas'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 4
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Pneu Bridge','Pneu Bridge aro 14','Pneu Bridge aro 14',100.00,'',200,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Pneus'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 800
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Limpa carro','Limpa carro','Limpa carro',10.00,'',3,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Acessórios'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 20
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Vara telescopica','Vara telescopica 3m','Vara telescopica 3m fibra de vidro',25.00,'',40,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Varas'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 3
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Isca artificial','Isca artificial 3mg','Isca artificial 3mg tipo plug',3.00,'',200,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Iscas'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 12
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Linha multifilamento','Linha multifilamento','Linha multifilamento',50.00,'',30,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Linhas'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO

DECLARE @count INT = 0;

WHILE @count < 3
BEGIN
    INSERT INTO [dbo].[Products]([Id],[Name],[Description],[Information],[Price],[Image],[Quantity],[SubcategoryId],[IsActive],[LastUpdate],[InclusionDate])
    VALUES (NEWID(),'Carretilha shimano','Carretilha shimano','Carretilha shimano 8 rolamentos',350.00,'',2,(SELECT TOP(1) [ID] FROM [dbo].[Subcategories] WHERE NAME LIKE 'Carretilha'),1,SYSDATETIMEOFFSET(),SYSDATETIMEOFFSET())
	SET @count = @count + 1;
END
GO


