-- AircraftSpecifications
INSERT INTO AIRCRAFT_SPECIFICATIONS (SpecificationId, Structure, FuelTankCapacity, MinSpeed, MaxSpeed, MaxAltitude, SpecificationCode)
VALUES
    (1, 100, 5000, 200, 800, 15000, 'SPEC-A1'),
    (2, 120, 5500, 250, 850, 16000, 'SPEC-B2'),
    (3, 130, 6000, 300, 900, 17000, 'SPEC-C3'),
    (4, 110, 5200, 220, 820, 15500, 'SPEC-D4'),
    (5, 140, 6500, 350, 950, 18000, 'SPEC-E5');

-- Aircrafts
INSERT INTO Aircrafts (AircraftId, SpecificationId, Fuel, Speed, Altitude, Name)
VALUES
    (1, 1, 3000, 600, 12000, 'Falcon-X'),
    (2, 2, 3500, 650, 13000, 'Storm-R'),
    (3, 3, 4000, 700, 14000, 'Eagle-Y'),
    (4, 4, 3200, 620, 12500, 'Hawk-Z'),
    (5, 5, 4500, 750, 15000, 'Viper-V');

-- Compartments
INSERT INTO Compartments (CompartmentId, AircraftId)
VALUES
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5);

-- Machineries
INSERT INTO Machineries (MachineId, Label, Function, CompartmentId, MachineryType)
VALUES
    (1, 'Main Engine', 'Provides thrust', 1, 'EnergySystem'),
    (2, 'Secondary Engine', 'Backup thrust', 2, 'EnergySystem'),
    (3, 'Cooling System', 'Regulates temperature', 3, 'EnvironmentalSystem'),
    (4, 'Defense Shield', 'Protects the aircraft', 4, 'EnvironmentalSystem'),
    (5, 'Steering System', 'Controls direction', 5, 'EnvironmentalSystem');

-- Weapons
INSERT INTO Machineries (MachineId, Label, Function, CompartmentId, MachineryType)
VALUES
    (6, 'Laser Cannon', 'Offensive weapon', 1, 'Weapon'),
    (7, 'Missile Launcher', 'Long-range attack', 2, 'Weapon'),
    (8, 'Machine Gun', 'Rapid fire weapon', 3, 'Weapon'),
    (9, 'Plasma Blaster', 'High energy shot', 4, 'Weapon'),
    (10, 'EMP Device', 'Disables electronics', 5, 'Weapon');

-- Mercenaries
INSERT INTO Mercenaries (MercenaryId, FirstName, LastName, BodySkills, CombatSkills)
VALUES
    (1, 'John', 'Doe', 80, 90),
    (2, 'Jane', 'Smith', 85, 95),
    (3, 'Max', 'Ryder', 75, 85),
    (4, 'Alice', 'Stone', 90, 100),
    (5, 'Leo', 'Knight', 88, 92);

-- AircraftCrew
INSERT INTO AIRCRAFT_CREW_JT (AircraftId, MercenaryId, JoinedAt)
VALUES
    (1, 1, '2025-02-19'),
    (2, 2, '2025-02-18'),
    (3, 3, '2025-02-17'),
    (4, 4, '2025-02-16'),
    (5, 5, '2025-02-15');

-- CrimeSyndicates
INSERT INTO CRIME_SYNDICATES (SyndicateId, Name, Location)
VALUES
    (1, 'Black Sun', 'Outer Rim'),
    (2, 'Red Dagger', 'Galactic Core'),
    (3, 'Void Raiders', 'Deep Space'),
    (4, 'Iron Claw', 'Asteroid Belt'),
    (5, 'Dark Fang', 'Unknown Region');

-- MercenaryReputations
INSERT INTO MERCENARY_REPUTATIONS (SyndicateId, MercenaryId, ReputationChange)
VALUES
    (1, 1, 'Increased'),
    (2, 2, 'Decreased'),
    (3, 3, 'Stable'),
    (4, 4, 'Increased'),
    (5, 5, 'Decreased');
