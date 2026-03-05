--create database BudwegDB

CREATE TABLE følgeseddel
(
    følgeseddelID   INT           NOT NULL IDENTITY(1,1),
    følgeseddelNr   INT           NOT NULL,
    spild           INT           NOT NULL CHECK (spild>=0),  
    tilgang         INT           NOT NULL CHECK (tilgang>=0),
    afgangFrem      INT           NOT NULL CHECK (afgangFrem>=0),
    afgangTilbage   INT           NOT NULL CHECK (afgangTilbage>=0),
    CONSTRAINT PK_Følgeseddel PRIMARY KEY CLUSTERED (følgeseddelID)
    
);
-- Station table
CREATE TABLE Station
(
    iD            INT           NOT NULL IDENTITY(1,1),
    navn          NVARCHAR(50)  NOT NULL,
    [dato/tidInd] DATETIME2     NOT NULL,
    [dato/tidUd]  DATETIME2     NULL CHECK ([dato/tidInd]<=[dato/tidUd]),
    CONSTRAINT PK_Station PRIMARY KEY CLUSTERED (iD)
);
GO

-- Medarbejder table
CREATE TABLE Medarbejder
(
    iD    INT           NOT NULL IDENTITY(1,1),
    navn  NVARCHAR(50)  NOT NULL,
    CONSTRAINT PK_Medarbejder PRIMARY KEY CLUSTERED (iD)
);
GO

-- Bakke table
CREATE TABLE Bakke
(
    iD      INT           NOT NULL IDENTITY(1,1),
    antal   INT           NOT NULL CHECK (antal>=0),
    produkt NVARCHAR(50)  NOT NULL,
    CONSTRAINT PK_Bakke PRIMARY KEY CLUSTERED (iD)
);
GO

-- Link table linking all four entities
CREATE TABLE Link
(
    LinkID           INT NOT NULL IDENTITY(1,1),
    FølgeseddelId    INT NOT NULL,
    StationId        INT NOT NULL,
    MedarbejderId    INT NOT NULL,
    BakkeId          INT NOT NULL,
    CONSTRAINT PK_Link PRIMARY KEY CLUSTERED (LinkID),

    CONSTRAINT FK_Link_Følgeseddel
        FOREIGN KEY (FølgeseddelId)
        REFERENCES Følgeseddel(følgeseddelID),

    CONSTRAINT FK_Link_Station
        FOREIGN KEY (StationId)
        REFERENCES Station(iD),

    CONSTRAINT FK_Link_Medarbejder
        FOREIGN KEY (MedarbejderId)
        REFERENCES Medarbejder(iD),

    CONSTRAINT FK_Link_Bakke
        FOREIGN KEY (BakkeId)
        REFERENCES Bakke(iD)
);
GO