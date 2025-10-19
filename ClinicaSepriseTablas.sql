-- ospostog4js_g13.INSUMOS definition

CREATE TABLE `INSUMOS` (
  `idinsumo` int(4) NOT NULL AUTO_INCREMENT COMMENT 'clave única de identificación del insumo',
  `nombreinsumo` varchar(120) NOT NULL COMMENT 'Nombre y/o descripción del insumo',
  `stockactual` int(3) NOT NULL COMMENT 'Stock disponible en depósito al momento de la consulta',
  `stockminimo` int(3) DEFAULT NULL COMMENT 'Stock mínimo.  Cuando el existente alcance este valor, debe generarse una alarma.',
  `proveedor` varchar(50) NOT NULL COMMENT 'Ultimo proveedor del insumo',
  PRIMARY KEY (`idinsumo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabla de TODOS los insumos de uso en las consultas.';


-- ospostog4js_g13.PERSONA definition

CREATE TABLE `PERSONA` (
  `apellido` varchar(20) NOT NULL COMMENT 'Apellido de las personas.',
  `nombre` varchar(20) NOT NULL COMMENT 'Nombre de las personas',
  `dni` int(9) NOT NULL COMMENT 'Documento con que se identifican unívocamente.',
  `fechanacimiento` date NOT NULL COMMENT 'Fecha de nacimiento (obligatoria)',
  `direccion` varchar(100) NOT NULL COMMENT 'Dirección compacta para contacto con la persona. Debe contener calle, numero, ciudad. Tratar de no abreviar a ilegibilidad.',
  `telefono` varchar(20) NOT NULL COMMENT 'Puede contener caracteres como +, - , / paraalternativos y la palabra INT(XXX) internos, donde XXX representa el número de interno.',
  `email` varchar(100) NOT NULL COMMENT 'Debe tener el formato convencional, nombredeusuario@dominio.ext.',
  PRIMARY KEY (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Base de información de las personas que trabajan en la cĺínica';


-- ospostog4js_g13.USUARIO definition

CREATE TABLE `USUARIO` (
  `idusuario` int(4) NOT NULL AUTO_INCREMENT COMMENT 'ckave de identificación del usuario (profesionales, administrativos)',
  `user` binary(1) NOT NULL COMMENT 'Nombre elegido por el usuario. Se almacena encriptado',
  `password` binary(1) NOT NULL COMMENT 'Clave de acceso seleccionada para el usuario',
  `rol` enum('Profesional','Administrativo') NOT NULL COMMENT 'rol del usuario "(sirve para administrar su nivel de acceso)"',
  PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabla para almacenamiento de nombre de usuario y clave';


-- ospostog4js_g13.ADMINISTRATIVO definition

CREATE TABLE `ADMINISTRATIVO` (
  `idadministrativo` int(3) NOT NULL COMMENT 'Clave única de identificación de aministrativos',
  `idpersona` int(9) NOT NULL COMMENT 'clave foránea para acceso de datos personales de administrativo',
  `idusuario` int(3) NOT NULL COMMENT 'Clave foránea para verificación de nombre de usuario y contraseña',
  PRIMARY KEY (`idadministrativo`),
  KEY `ADMINISTRATIVO_USUARIO_FK` (`idusuario`),
  CONSTRAINT `ADMINISTRATIVO_PERSONA_FK` FOREIGN KEY (`idadministrativo`) REFERENCES `PERSONA` (`dni`),
  CONSTRAINT `ADMINISTRATIVO_USUARIO_FK` FOREIGN KEY (`idusuario`) REFERENCES `USUARIO` (`idusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabla de datos complementarios a Persona para definir administrativos.';


-- ospostog4js_g13.PACIENTE definition

CREATE TABLE `PACIENTE` (
  `Idpaciente` int(6) NOT NULL AUTO_INCREMENT,
  `dni` int(9) NOT NULL COMMENT 'Clave foránea para concatenación con PERSONA',
  `obrasocial` int(3) NOT NULL DEFAULT 0 COMMENT 'Clave foránea asociada a la tabla de Obras Sociales',
  `numeroafiliado` varchar(15) NOT NULL DEFAULT 'No posee' COMMENT 'Numero asignado al paciente como socio de la obra social/medicina prepaga',
  `historiaclinica` int(6) NOT NULL,
  PRIMARY KEY (`Idpaciente`),
  KEY `PACIENTE_PERSONA_FK` (`dni`),
  CONSTRAINT `PACIENTE_PERSONA_FK` FOREIGN KEY (`dni`) REFERENCES `PERSONA` (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabla con datos adicionales para los pacientes de la clínica. Asociada a PERSONAS';


-- ospostog4js_g13.PROFESIONAL definition

CREATE TABLE `PROFESIONAL` (
  `idprofesional` int(3) NOT NULL AUTO_INCREMENT COMMENT 'Identificador único de profesionales (médicos)',
  `idpersona` int(9) NOT NULL COMMENT 'clave foránea que conecta con los datos personales del profesional',
  `idusuario` int(3) NOT NULL COMMENT 'clave de relación con la tabla de claves de usuario y contraseñas de los habilitados para acceder al sistema.',
  `idespecialidad` int(3) NOT NULL COMMENT 'Clave foránea para conectar con la tabla de especialidaes asociadas al profesional.',
  `matricula` varchar(10) NOT NULL COMMENT 'Matricula profesional del médico, con la que firma indicaciones de tratamientos y recetas.',
  `iddisponibilidad` int(4) NOT NULL COMMENT 'Clave foránea para acceso a la disponibilidad (convenio de horarios de trabajo del profesional) Cada registro refleja un período de tiempo, en determinado día de la semana.\nPuede repetirse por profesional en el mismo día y diferente horario\nPueden ser varios días y algunas veces en el mismo día también. Se considera una semana (7 días) Comenzando con 1 el Lunes y 7 el Domingo.',
  `consultasrealizadas` int(3) DEFAULT 0 COMMENT 'Numero de consultas realizadas por ciclo de facturación (mensual en principio)',
  PRIMARY KEY (`idprofesional`),
  KEY `PROFESIONAL_PERSONA_FK` (`idpersona`),
  KEY `PROFESIONAL_USUARIO_FK` (`idusuario`),
  CONSTRAINT `PROFESIONAL_PERSONA_FK` FOREIGN KEY (`idpersona`) REFERENCES `PERSONA` (`dni`),
  CONSTRAINT `PROFESIONAL_USUARIO_FK` FOREIGN KEY (`idusuario`) REFERENCES `USUARIO` (`idusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabla de datos accesorios para la definición como profesional de la salud';


-- ospostog4js_g13.AGENDA definition

CREATE TABLE `AGENDA` (
  `idturno` int(6) NOT NULL COMMENT 'Identificador único del turno creado',
  `fechaturno` datetime NOT NULL COMMENT 'Fecha y hora del turno asignado',
  `duracionturno` time DEFAULT NULL COMMENT 'Duración del turno creado.',
  `idprofesional` int(3) NOT NULL COMMENT 'Identidad de l profesional asignado para este turno',
  `idpaciente` int(6) NOT NULL COMMENT 'Identidad del paciente asignado para este turno',
  `monto` double NOT NULL COMMENT 'Monto de la consulta',
  `estado` enum('Libre','Asignado','Iniciado','Terminado') NOT NULL COMMENT 'Estado actual del turno creado.',
  PRIMARY KEY (`idturno`),
  KEY `AGENDA_PROFESIONAL_FK` (`idprofesional`),
  KEY `AGENDA_PACIENTE_FK` (`idpaciente`),
  CONSTRAINT `AGENDA_PACIENTE_FK` FOREIGN KEY (`idpaciente`) REFERENCES `PACIENTE` (`Idpaciente`),
  CONSTRAINT `AGENDA_PROFESIONAL_FK` FOREIGN KEY (`idprofesional`) REFERENCES `PROFESIONAL` (`idprofesional`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Registro de los turnos disponibles';


-- ospostog4js_g13.DISPONIBILIDAD definition

CREATE TABLE `DISPONIBILIDAD` (
  `iddisponibilidad` int(3) NOT NULL COMMENT 'Identificador de convenio de cada médico organizados como 1 registro por horas de consulta por cada día de la semana. Modificable con anticipación adecuada a la creación de turnos',
  `idprofesional` int(3) NOT NULL COMMENT 'identidad del profesional otorgante. Clave foranea.',
  `dia` enum('Lunes','Martes','Miércoles','Jueves','Viernes','Sábado','Domingo') DEFAULT NULL COMMENT 'Días de la semana',
  `horainicio` time NOT NULL COMMENT 'Horario de inicio del período de consulta',
  `horafin` time NOT NULL COMMENT 'Horario del final del período de consulta',
  PRIMARY KEY (`iddisponibilidad`),
  KEY `DISPONIBILIDAD_PROFESIONAL_FK` (`idprofesional`),
  CONSTRAINT `DISPONIBILIDAD_PROFESIONAL_FK` FOREIGN KEY (`idprofesional`) REFERENCES `PROFESIONAL` (`idprofesional`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Acuerdo de presencialidad de los profesionales con la clínica. Necesario para programación de turnos.';


-- ospostog4js_g13.PAGOS definition

CREATE TABLE `PAGOS` (
  `idfactura` int(7) NOT NULL COMMENT 'identificador único de la factura emitida o a emitir',
  `idpaciente` int(7) NOT NULL COMMENT 'clave de identificación del paciente.',
  `idturno` int(6) NOT NULL COMMENT 'Identificador del turno en el que el paciente realizará la consulta.',
  `fechaemision` datetime NOT NULL COMMENT 'fecha y hora  de emisión del comprobante',
  `monto` float DEFAULT NULL COMMENT 'Monto total facturado',
  `metodopago` enum('Efectivo','Tarjeta','Obra Social') NOT NULL COMMENT 'Forma de pago elegida',
  `estadopago` enum('Pendiente','Pagado') NOT NULL COMMENT 'Estado de la factura',
  PRIMARY KEY (`idfactura`),
  KEY `PAGOS_PACIENTE_FK` (`idpaciente`),
  KEY `PAGOS_AGENDA_FK` (`idturno`),
  CONSTRAINT `PAGOS_AGENDA_FK` FOREIGN KEY (`idturno`) REFERENCES `AGENDA` (`idturno`),
  CONSTRAINT `PAGOS_PACIENTE_FK` FOREIGN KEY (`idpaciente`) REFERENCES `PACIENTE` (`Idpaciente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Pagos por las consultas, montos, fechas,  formas de pago y estdado.';


-- ospostog4js_g13.PEDIDOINSUMO definition

CREATE TABLE `PEDIDOINSUMO` (
  `idinsumo` int(4) NOT NULL AUTO_INCREMENT COMMENT 'Identificador del pedido de insumos',
  `idprofesional` int(3) NOT NULL COMMENT 'Identificador del profesional que realiza el pedido.',
  `idconsultorio` int(2) NOT NULL COMMENT 'Identificador del consultorio donde proveer el insumo',
  `cantidad` int(3) NOT NULL COMMENT 'Cantidad de unidades del insumo solicitado',
  `detalle` varchar(100) DEFAULT NULL COMMENT 'comentarios opcionales relacionados con los insumos solicitados',
  PRIMARY KEY (`idinsumo`),
  KEY `PEDIDOINSUMO_PROFESIONAL_FK` (`idprofesional`),
  CONSTRAINT `PEDIDOINSUMO_INSUMOS_FK` FOREIGN KEY (`idinsumo`) REFERENCES `INSUMOS` (`idinsumo`),
  CONSTRAINT `PEDIDOINSUMO_PROFESIONAL_FK` FOREIGN KEY (`idprofesional`) REFERENCES `PROFESIONAL` (`idprofesional`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Tabla de pedidos de insumos relacionados con los profesionales y su práctica.';
