use ospostog4js_g13;

-- *** 2. INSERCIÓN DE 55 PERSONAS (15 EMPLEADOS + 40 PACIENTES) ***

-- 10 Profesionales (Edades entre 30 y 60 años)
INSERT INTO PERSONA (apellido, nombre, dni, sexo, fechanacimiento, direccion, telefono, email) VALUES
('Gómez', 'Pedro', 25123456, 'Hombre', '1975-03-10', 'Calle Falsa 123, Ciudad A', '+54 11 4567-8900', 'pedro.gomez@clinica.com'),  -- 50 años
('López', 'Ana', 30234567, 'Mujer', '1990-11-20', 'Av. Siempreviva 456, Ciudad B', '0800-222-3333', 'ana.lopez@clinica.com'),    -- 34 años
('Ruiz', 'Martín', 20345678, 'Hombre', '1965-07-01', 'Boulevard 789, Ciudad C', 'INT(101)', 'martin.ruiz@clinica.com'),      -- 60 años
('García', 'Sofía', 32456789, 'Mujer', '1995-02-15', 'Pasaje 101, Ciudad D', '+54 9 11 5555-4444', 'sofia.garcia@clinica.com'), -- 30 años
('Díaz', 'Ricardo', 28567890, 'Hombre', '1980-05-25', 'Ruta Nacional 20, Ciudad E', '444-5555/INT(205)', 'ricardo.diaz@clinica.com'),-- 45 años
('Vidal', 'Elena', 35678901, 'Mujer', '1988-12-05', 'Calle del Sol 300, Ciudad F', '+54 351 999-8888', 'elena.vidal@clinica.com'),  -- 36 años
('Mora', 'Javier', 23789012, 'Hombre', '1972-09-18', 'Av. Central 50, Ciudad G', '011-3000-4000', 'javier.mora@clinica.com'),    -- 53 años
('Soto', 'Carla', 31890123, 'Mujer', '1992-04-04', 'Los Alamos 15, Ciudad H', 'INT(302)', 'carla.soto@clinica.com'),       -- 33 años
('Torres', 'Andrés', 29901234, 'Hombre', '1985-06-08', 'Calle Larga 200, Ciudad I', '+54 221 777-6666', 'andres.torres@clinica.com'), -- 40 años
('Nuñez', 'Lucía', 33012345, 'Mujer', '1994-01-28', 'Las Flores 10, Ciudad J', '555-1234', 'lucia.nunez@clinica.com');   -- 31 años

-- 5 Administrativos (Edades entre 30 y 60 años)
INSERT INTO PERSONA (apellido, nombre, dni, sexo, fechanacimiento, direccion, telefono, email) VALUES
('Castro', 'Raúl', 26112233, 'Hombre', '1978-08-14', 'Calle A 10, Ciudad K', '+54 11 6000-1000', 'raul.castro@clinica.com'), -- 47 años
('Blanco', 'Marta', 34223344, 'Mujer', '1991-03-22', 'Calle B 20, Ciudad L', 'INT(501)', 'marta.blanco@clinica.com'),   -- 34 años
('Silva', 'Diego', 27334455, 'Hombre', '1983-01-05', 'Calle C 30, Ciudad M', '456-7890', 'diego.silva@clinica.com'),    -- 42 años
('Pérez', 'Laura', 36445566, 'Mujer', '1993-07-11', 'Calle D 40, Ciudad N', '+54 381 123-4567', 'laura.perez@clinica.com'), -- 32 años
('Ferrero', 'Enzo', 24556677, 'Hombre', '1970-04-30', 'Calle E 50, Ciudad O', '0810-777-0000', 'enzo.ferrero@clinica.com'); -- 55 años

-- 40 Pacientes (Edades variadas para cubrir las especialidades)
INSERT INTO PERSONA (apellido, nombre, dni, sexo, fechanacimiento, direccion, telefono, email) VALUES
-- Pacientes Pediátricos (Menores de 10 años)
('Méndez', 'Felipe', 48000001, 'Hombre', '2023-01-10', 'Dir P1', '11111', 'felipe.mendez@mail.com'), -- 2 años
('Rojas', 'Clara', 49000002, 'Mujer', '2020-05-05', 'Dir P2', '22222', 'clara.rojas@mail.com'),     -- 5 años
-- Pacientes Adultos Jóvenes (Relación con Ginecología)
('Luna', 'María', 40000003, 'Mujer', '1998-09-12', 'Dir P3', '33333', 'maria.luna@mail.com'),        -- 27 años (Embarazo/Gine)
('Vera', 'Natalia', 41000004, 'Mujer', '1985-11-28', 'Dir P4', '44444', 'natalia.vera@mail.com'),      -- 40 años (Gine/Dermato)
-- Pacientes de Edad Avanzada (Relación con Geriatría/Cardiología/Neurología)
('Gil', 'Alfredo', 15000005, 'Hombre', '1955-02-01', 'Dir P5', '55555', 'alfredo.gil@mail.com'),      -- 70 años (Geriatría)
('Paz', 'Berta', 18000006, 'Mujer', '1960-06-16', 'Dir P6', '66666', 'berta.paz@mail.com'),         -- 65 años (Cardiología)
('Sánchez', 'Roberto', 12000007, 'Hombre', '1945-03-20', 'Dir P7', '77777', 'roberto.sanchez@mail.com'), -- 80 años (Neurología)
-- Pacientes Varios y Cobertura de Género/Edad
('Peralta', 'Laura', 38000008, 'Mujer', '1982-10-21', 'Dir P8', '88888', 'laura.peralta@mail.com'),
('Gómez', 'Juan', 37000009, 'Hombre', '1979-01-01', 'Dir P9', '99999', 'juan.gomez@mail.com'),
('Ramírez', 'Paula', 39000010, 'Mujer', '1991-04-15', 'Dir P10', '10101', 'paula.ramirez@mail.com'),
('Suárez', 'Carlos', 42000011, 'Hombre', '2005-08-01', 'Dir P11', '11211', 'carlos.suarez@mail.com'),
('Acosta', 'Romina', 36000012, 'Mujer', '1987-03-03', 'Dir P12', '12312', 'romina.acosta@mail.com'),
('Benítez', 'Diego', 35000013, 'Hombre', '1970-12-12', 'Dir P13', '13413', 'diego.benitez@mail.com'),
('Correa', 'Valeria', 43000014, 'Mujer', '1996-06-20', 'Dir P14', '14514', 'valeria.correa@mail.com'),
('Díaz', 'Esteban', 34000015, 'Hombre', '1968-04-09', 'Dir P15', '15615', 'esteban.diaz@mail.com'),
('Espinoza', 'Florencia', 44000016, 'Mujer', '2000-01-25', 'Dir P16', '16716', 'flor.espinoza@mail.com'),
('Fernández', 'Gastón', 33000017, 'Hombre', '1981-11-05', 'Dir P17', '17817', 'gaston.fdez@mail.com'),
('Gutiérrez', 'Hugo', 32000018, 'Hombre', '1975-02-18', 'Dir P18', '18918', 'hugo.gutierrez@mail.com'),
('Herrera', 'Isabel', 45000019, 'Mujer', '2002-09-03', 'Dir P19', '19019', 'isabel.herrera@mail.com'),
('Ibarra', 'Jorge', 31000020, 'Hombre', '1962-07-07', 'Dir P20', '20120', 'jorge.ibarra@mail.com'),
('Juárez', 'Karina', 46000021, 'Mujer', '2004-12-09', 'Dir P21', '21221', 'karina.juarez@mail.com'),
('Kuc', 'Lio', 30000022, 'Hombre', '1993-05-14', 'Dir P22', '22322', 'lio.kuc@mail.com'),
('Ledesma', 'Mónica', 29000023, 'Mujer', '1977-10-10', 'Dir P23', '23423', 'monica.ledesma@mail.com'),
('Molina', 'Néstor', 28000024, 'Hombre', '1965-08-28', 'Dir P24', '24524', 'nestor.molina@mail.com'),
('Navarro', 'Ofelia', 47000025, 'Mujer', '2001-03-30', 'Dir P25', '25625', 'ofelia.navarro@mail.com'),
('Ocampo', 'Pablo', 27000026, 'Hombre', '1984-09-07', 'Dir P26', '26726', 'pablo.ocampo@mail.com'),
('Ortiz', 'Quimey', 48000027, 'Mujer', '2003-02-19', 'Dir P27', '27827', 'quimey.ortiz@mail.com'),
('Peralta', 'Ramón', 26000028, 'Hombre', '1973-12-04', 'Dir P28', '28928', 'ramon.peralta@mail.com'),
('Quinteros', 'Silvia', 49000029, 'Mujer', '1990-05-17', 'Dir P29', '29029', 'silvia.q@mail.com'),
('Ríos', 'Tomás', 25000030, 'Hombre', '1969-01-22', 'Dir P30', '30130', 'tomas.rios@mail.com'),
('Sosa', 'Úrsula', 39000031, 'Mujer', '1986-07-29', 'Dir P31', '31231', 'ursula.sosa@mail.com'),
('Toro', 'Víctor', 24000032, 'Hombre', '1976-11-16', 'Dir P32', '32332', 'victor.toro@mail.com'),
('Uribe', 'Wendy', 38000033, 'Mujer', '1999-04-24', 'Dir P33', '33433', 'wendy.uribe@mail.com'),
('Vargas', 'Xavier', 23000034, 'Hombre', '1967-03-13', 'Dir P34', '34534', 'xavier.vargas@mail.com'),
('Wong', 'Yésica', 37000035, 'Mujer', '1980-08-19', 'Dir P35', '35635', 'yesica.wong@mail.com'),
('Xavier', 'Zoe', 22000036, 'Mujer', '1995-12-01', 'Dir P36', '36736', 'zoe.xavier@mail.com'),
('Yáñez', 'Alan', 21000037, 'Hombre', '1974-05-11', 'Dir P37', '37837', 'alan.yanez@mail.com'),
('Zárate', 'Belén', 36000038, 'Mujer', '1997-10-27', 'Dir P38', '38938', 'belen.zarate@mail.com'),
('Alvarez', 'Ciro', 20000039, 'Hombre', '1964-02-06', 'Dir P39', '39039', 'ciro.alvarez@mail.com'),
('Blanco', 'Delfina', 40000040, 'Mujer', '2006-12-15', 'Dir P40', '40140', 'delfina.blanco@mail.com');

-- *** 1. INSERCIÓN DE 15 USUARIOS (PROFESIONALES Y ADMINISTRATIVOS) USANDO UNHEX() ***
-- Se inserta el valor BINARIO de 16 bytes, generado de la cadena original.
-- Los valores Hexadecimales son: [Texto Original] => [32 caracteres Hex]

INSERT INTO USUARIO (idusuario, user, password, rol) VALUES
-- PROFESIONALES
(1, UNHEX('70726F665F706564726F2E676F6D657A'), UNHEX('50737764506772310000000000000000'), 'Profesional'), -- prof_pedro.gomez, PswdPgr1
(2, UNHEX('70726F665F616E612E6C6F70657A0000'), UNHEX('50737764416C70320000000000000000'), 'Profesional'), -- prof_ana.lopez, PswdAlp2
(3, UNHEX('70726F665F6D617274696E2E7275697A'), UNHEX('507377644D727A330000000000000000'), 'Profesional'), -- prof_martin.ruiz, PswdMrz3
(4, UNHEX('70726F665F736F6669612E6761726369'), UNHEX('50737764536763340000000000000000'), 'Profesional'), -- prof_sofia.garcia, PswdSgc4
(5, UNHEX('70726F665F7269636172646F2E646961'), UNHEX('5073776452647A350000000000000000'), 'Profesional'), -- prof_ricardo.diaz, PswdRdz5
(6, UNHEX('70726F665F656C656E612E766964616C'), UNHEX('50737764457664360000000000000000'), 'Profesional'), -- prof_elena.vidal, PswdEvd6
(7, UNHEX('70726F665F6A61766965722E6D6F7261'), UNHEX('507377644A6D72370000000000000000'), 'Profesional'), -- prof_javier.mora, PswdJmr7
(8, UNHEX('70726F665F6361726C612E736F746F00'), UNHEX('50737764437374380000000000000000'), 'Profesional'), -- prof_carla.soto, PswdCst8
(9, UNHEX('70726F665F616E647265732E746F7272'), UNHEX('50737764417472390000000000000000'), 'Profesional'), -- prof_andres.torres, PswdAtr9
(10, UNHEX('70726F665F6C756369612E6E75C3B165'), UNHEX('507377644C6EC3B13000000000000000'), 'Profesional'), -- prof_lucia.nuñez, PswdLnñ0
(11, UNHEX('61646D5F7261756C2E63617374726F00'), UNHEX('50737764526373740000000000000000'), 'Administrativo'), -- adm_raul.castro, PswdRcst
(12, UNHEX('61646D5F6D617274612E626C616E636F'), UNHEX('507377644D626C630000000000000000'), 'Administrativo'), -- adm_marta.blanco, PswdMblc
(13, UNHEX('61646D5F646965676F2E73696C766100'), UNHEX('5073776444736C760000000000000000'), 'Administrativo'), -- adm_diego.silva, PswdDslv
(14, UNHEX('61646D5F6C617572612E706572657A00'), UNHEX('507377644C7072780000000000000000'), 'Administrativo'), -- adm_laura.perez, PswdLprx
(15, UNHEX('61646D5F656E7A6F2E6665727265726F'), UNHEX('50737764456672720000000000000000'), 'Administrativo'); -- adm_enzo.ferrero

-- *** 3. INSERCIÓN DE 10 PROFESIONALES ***
-- idpersona es el DNI de la persona (FK a PERSONA.dni)
-- idusuario es el ID del usuario (FK a USUARIO.idusuario)
-- idespecialidad: 1=Cardiología, 2=Pediatría, 3=Geriatría, 4=Ginecología, 5=Traumatología, 6=Dermatología, 7=Clínica Médica, 8=Oftalmología, 9=Urología, 10=Neurología

INSERT INTO PROFESIONAL (idprofesional, idpersona, idusuario, idespecialidad, matricula, iddisponibilidad, consultasrealizadas) VALUES
(1, 25123456, 1, 1, 'MP-1001', 1, 0), -- Pedro Gómez (Cardiología)
(2, 30234567, 2, 2, 'MP-1002', 1, 0), -- Ana López (Pediatría)
(3, 20345678, 3, 3, 'MP-1003', 1, 0), -- Martín Ruiz (Geriatría)
(4, 32456789, 4, 4, 'MP-1004', 1, 0), -- Sofía García (Ginecología)
(5, 28567890, 5, 5, 'MP-1005', 1, 0), -- Ricardo Díaz (Traumatología)
(6, 35678901, 6, 6, 'MP-1006', 1, 0), -- Elena Vidal (Dermatología)
(7, 23789012, 7, 7, 'MP-1007', 1, 0), -- Javier Mora (Clínica Médica)
(8, 31890123, 8, 8, 'MP-1008', 1, 0), -- Carla Soto (Oftalmología)
(9, 29901234, 9, 9, 'MP-1009', 1, 0), -- Andrés Torres (Urología)
(10, 33012345, 10, 10, 'MP-1010', 1, 0); -- Lucía Nuñez (Neurología)

-- *** 4. INSERCIÓN DE 5 ADMINISTRATIVOS ***
-- idadministrativo es el DNI de la persona (PK y FK a PERSONA.dni)
-- idpersona es el DNI de la persona (columna de repetición)
-- idusuario es el ID del usuario (FK a USUARIO.idusuario)

INSERT INTO ADMINISTRATIVO (idadministrativo, idpersona, idusuario) VALUES
(26112233, 26112233, 11), -- Raúl Castro
(34223344, 34223344, 12), -- Marta Blanco
(27334455, 27334455, 13), -- Diego Silva
(36445566, 36445566, 14), -- Laura Pérez
(24556677, 24556677, 15); -- Enzo Ferrero

-- *** 5. INSERCIÓN DE 40 PACIENTES (ACTUALIZADO CON IDs DE OBRA SOCIAL 1-20) ***
-- El campo obrasocial (int(3)) ahora referencia a una de las 20 Obras Sociales listadas.
-- El resto de las claves (dni, idpaciente) se mantienen sin cambios.

INSERT INTO PACIENTE (dni, fechaingreso, obrasocial, numeroafiliado, historiaclinica) VALUES
(48000001, NOW(), 5, '48000001-A', 1), -- O.S.P.E.
(49000002, NOW(), 12, '49000002-B', 1), -- Galeno
(40000003, NOW(), 8, '40000003-C', 1), -- Cobertura Azul
(41000004, NOW(), 18, '41000004-D', 1), -- O.S.P.I.L.
(15000005, NOW(), 1, '15000005-E', 1), -- Salud Total
(18000006, NOW(), 10, '18000006-F', 1), -- Sancor Salud
(12000007, NOW(), 13, '12000007-G', 1), -- O.S.D.E.
(38000008, NOW(), 2, '38000008-H', 1), -- Prevenir Salud
(37000009, NOW(), 15, '37000009-I', 1), -- Consultar Ahora
(39000010, NOW(), 4, '39000010-J', 1), -- O.S.P.E.
(42000011, NOW(), 17, '42000011-K', 1), -- Red de Sanación
(36000012, NOW(), 11, '36000012-L', 1), -- Swiss Medical
(35000013, NOW(), 6, '35000013-M', 1), -- Plan Integral
(43000014, NOW(), 19, '43000014-N', 1), -- Grupo Médico Sur
(34000015, NOW(), 7, '34000015-O', 1), -- Asegurar Vida
(44000016, NOW(), 3, '44000016-P', 1), -- Medicina Activa
(33000017, NOW(), 14, '33000017-Q', 1), -- Prevención Médica
(32000018, NOW(), 16, '32000018-R', 1), -- Bienestar Total
(45000019, NOW(), 9, '45000019-S', 1), -- O.S.M.A.
(31000020, NOW(), 20, '31000020-T', 1), -- Servicio Superior
(46000021, NOW(), 10, '46000021-U', 1), -- Sancor Salud
(30000022, NOW(), 13, '30000022-V', 1), -- O.S.D.E.
(29000023, NOW(), 1, '29000023-W', 1), -- Salud Total
(28000024, NOW(), 5, '28000024-X', 1), -- O.S.P.E.
(47000025, NOW(), 18, '47000025-Y', 1), -- O.S.P.I.L.
(27000026, NOW(), 2, '27000026-Z', 1), -- Prevenir Salud
(48000027, NOW(), 8, '48000027-AA', 1), -- Cobertura Azul
(26000028, NOW(), 12, '26000028-BB', 1), -- Galeno
(49000029, NOW(), 15, '49000029-CC', 1), -- Consultar Ahora
(25000030, NOW(), 4, '25000030-DD', 1), -- O.S.P.E.
(39000031, NOW(), 17, '39000031-EE', 1), -- Red de Sanación
(24000032, NOW(), 11, '24000032-FF', 1), -- Swiss Medical
(38000033, NOW(), 6, '38000033-GG', 1), -- Plan Integral
(23000034, NOW(), 19, '23000034-HH', 1), -- Grupo Médico Sur
(37000035, NOW(), 7, '37000035-II', 1), -- Asegurar Vida
(22000036, NOW(), 3, '22000036-JJ', 1), -- Medicina Activa
(21000037, NOW(), 14, '21000037-KK', 1), -- Prevención Médica
(36000038, NOW(), 16, '36000038-LL', 1), -- Bienestar Total
(20000039, NOW(), 9, '20000039-MM', 1), -- O.S.M.A.
(40000040, NOW(), 20, '40000040-NN', 1); -- Servicio Superior

-- *** 6. INSERCIÓN DE DISPONIBILIDAD (20 REGISTROS PARA 10 PROFESIONALES) ***

INSERT INTO DISPONIBILIDAD (iddisponibilidad, idprofesional, dia, horainicio, horafin) VALUES
-- PROFESIONAL 1: Cardiología (Pedro Gómez)
(1, 1, 'Lunes', '08:00:00', '12:00:00'),
(2, 1, 'Miércoles', '08:00:00', '12:00:00'),
-- PROFESIONAL 2: Pediatría (Ana López)
(3, 2, 'Lunes', '14:00:00', '18:00:00'),
(4, 2, 'Viernes', '14:00:00', '18:00:00'),
-- PROFESIONAL 3: Geriatría (Martín Ruiz)
(5, 3, 'Martes', '09:00:00', '13:00:00'),
(6, 3, 'Jueves', '09:00:00', '13:00:00'),
-- PROFESIONAL 4: Ginecología (Sofía García)
(7, 4, 'Lunes', '15:00:00', '19:00:00'),
(8, 4, 'Miércoles', '15:00:00', '19:00:00'),
-- PROFESIONAL 5: Traumatología (Ricardo Díaz)
(9, 5, 'Martes', '08:30:00', '12:30:00'),
(10, 5, 'Viernes', '08:30:00', '12:30:00'),
-- PROFESIONAL 6: Dermatología (Elena Vidal)
(11, 6, 'Martes', '13:00:00', '17:00:00'),
(12, 6, 'Jueves', '13:00:00', '17:00:00'),
-- PROFESIONAL 7: Clínica Médica (Javier Mora)
(13, 7, 'Miércoles', '09:30:00', '13:30:00'),
(14, 7, 'Viernes', '09:30:00', '13:30:00'),
-- PROFESIONAL 8: Oftalmología (Carla Soto)
(15, 8, 'Lunes', '16:00:00', '20:00:00'),
(16, 8, 'Jueves', '16:00:00', '20:00:00'),
-- PROFESIONAL 9: Urología (Andrés Torres)
(17, 9, 'Martes', '10:00:00', '14:00:00'),
(18, 9, 'Miércoles', '10:00:00', '14:00:00'),
-- PROFESIONAL 10: Neurología (Lucía Nuñez)
(19, 10, 'Jueves', '14:30:00', '18:30:00'),
(20, 10, 'Viernes', '14:30:00', '18:30:00');

-- *** 7. INSERCIÓN DE 30 INSUMOS ***

INSERT INTO INSUMOS (idinsumo, nombreinsumo, stockactual, stockminimo, proveedor) VALUES
(1, 'Guantes de látex (caja)', 120, 40, 'Provisiones Médicas S.A.'),
(2, 'Alcohol en gel (litro)', 150, 50, 'Químicos Hospitalarios'),
(3, 'Gasas estériles (paquete)', 200, 50, 'Farmacia Central'),
(4, 'Jeringas descartables 5ml (caja)', 100, 30, 'Suministros Rápido'),
(5, 'Termómetros digitales', 25, 8, 'Medir Bien'),
(6, 'Electrodos ECG (paq. x50)', 50, 10, 'CardioStock'),
(7, 'Kit de Monitoreo Fetal', 5, 3, 'MamiCare'),
(8, 'Tiras reactivas de glucosa', 80, 20, 'DiabTest'),
(9, 'Oftalmoscopio desechable', 15, 5, 'Visión Clara'),
(10, 'Crema anestésica tópica', 30, 10, 'DermoPharma'),
(11, 'Bota para inmovilización (unid.)', 12, 5, 'Ortopedia Sur'),
(12, 'Catéteres Foley (unid.)', 40, 10, 'UroLogic'),
(13, 'Pañales para adultos (paq.)', 70, 25, 'Cuidado Mayor'),
(14, 'Sonda nasogástrica (unid.)', 20, 5, 'MedInt'),
(15, 'Espéculo vaginal (descartable)', 80, 20, 'GynoPlus'),
(16, 'Cánula de Guedel (unid.)', 15, 5, 'EmerServ'),
(17, 'Martillo de reflejos', 10, 3, 'NeuroTools'),
(18, 'Esparadrapo hipoalergénico', 110, 30, 'FixaTodo'),
(19, 'Vendas elásticas 10cm', 90, 25, 'Ortopedia Sur'),
(20, 'Vacunas Antigripales (dosis)', 30, 5, 'VacuMed'),
(21, 'Suturas absorbibles (caja)', 45, 15, 'Quirúrgico S.A.'),
(22, 'Tensiometro de brazalete', 15, 5, 'Medir Bien'),
(23, 'Kits de test rápido de embarazo', 50, 15, 'GynoPlus'),
(24, 'Lentes de contacto de prueba (caja)', 20, 5, 'Visión Clara'),
(25, 'Esponjas de limpieza facial', 35, 10, 'DermoPharma'),
(26, 'Férulas digitales (unid.)', 8, 3, 'Ortopedia Sur'),
(27, 'Gotas oftálmicas anestésicas', 40, 10, 'Visión Clara'),
(28, 'Guantes de vinilo (caja)', 100, 30, 'Provisiones Médicas S.A.'),
(29, 'Lancetas para punción capilar', 60, 15, 'DiabTest'),
(30, 'Antiséptico a base de yodo (litro)', 90, 25, 'Químicos Hospitalarios');
