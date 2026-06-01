# Hospital - Diseño de UI/UX (WinForms)

Este documento describe la **estructura visual** y los **controles WinForms** requeridos para el sistema hospitalario. No incluye código funcional ni conexión a base de datos.

## Alcance
- Formularios de portal, login y dashboards.
- Disposición de layout (Panels, TabControls, SplitContainers, etc.).
- Controles exactos por formulario y por sección.

## Reglas críticas de UI
- **Pacientes:** prioridad obligatoria visible: `1=URGENT (URGENTE)`, `2=HIGH (ALTA)`, `3=MEDIUM (MEDIA)`, `4=LOW (BAJA)`.
- **Citas:** estados válidos: `PENDIENTE`, `ATENDIDA`, `CANCELADA`.
- **Recetas:** solo para citas **ATENDIDAS** (habilitar panel de receta solo en ese estado).

## Accesibilidad y localización
- Los textos de `AccessibleName`, `AccessibleDescription` y mensajes visibles deben **localizarse** según el idioma del usuario.
- Para campos de solo lectura tipo `TextBox`, preferir `ReadOnly = true` para conservar foco y navegación por teclado.
- Para listas no editables (`ComboBox`), preferir `DropDownStyle = DropDownList`; si se deshabilitan, mostrar el valor también en un `Label` de solo lectura.

---

# 1) Portal de Inicio (Bifurcación)

## Formulario: `FrmPortalInicio`
**Objetivo:** selector de rol con dos rutas claras.

**Disposición:**
- `TableLayoutPanel` con 2 columnas (50/50) **o** `SplitContainer` vertical.
- Cada columna con un `Panel` tipo “tarjeta”.

**Controles:**
- `Label` título de bienvenida.
- `PictureBox` logo hospital.
- **Tarjeta Personal:**
  - `Label` título.
  - `Label` descripción breve.
  - `Button` “Ingreso como Personal”.
- **Tarjeta Paciente:**
  - `Label` título.
  - `Label` descripción breve.
  - `Button` “Ingreso como Paciente”.

---

# 2) Flujo de Personal

## Formulario: `FrmStaffLogin`
**Disposición:**
- `Panel` central con formulario compacto (align center).

**Controles:**
- `Label` “Usuario”.
- `TextBox` usuario.
- `Label` “Contraseña”.
- `TextBox` contraseña (`UseSystemPasswordChar = true`).
- `Button` “Iniciar sesión”.
- `LinkLabel` “¿Olvidaste tu contraseña?” (opcional).

---

## Formulario: `FrmAdminDashboard`
**Disposición:**
- `Panel` lateral izquierdo de navegación.
- `TabControl` principal con tabs: **Pacientes**, **Médicos**, **Citas**, **Especialidades**.

**Controles generales:**
- `Panel` lateral con botones de acceso rápido.
- `TabControl` con `TabPage` por módulo.
- En cada tab: `DataGridView` + `GroupBox` de detalle + botones CRUD.

### Tab: Pacientes
- `DataGridView` listado.
- `GroupBox` “Detalle Paciente” con:
  - `TextBox` Nombre.
  - `TextBox` Apellidos.
  - `TextBox` CURP.
  - `DateTimePicker` Fecha de nacimiento.
  - `ComboBox` **Prioridad** (1=Urgente, 2=Alta, 3=Media, 4=Baja) **visible y obligatorio**.
- Botones: `Button` Nuevo, Guardar, Editar, Eliminar, Limpiar.

### Tab: Médicos
- `DataGridView` listado.
- `TextBox` Nombre.
- `TextBox` Apellidos.
- `TextBox` Teléfono.
- `TextBox` Email.
- `TextBox` Cédula profesional (única).
- `ComboBox` Especialidad.
- `CheckBox` Activo/Inactivo.
- Botones CRUD.

### Tab: Especialidades
- `DataGridView` listado.
- `TextBox` Nombre de especialidad.
- Botones CRUD.

### Tab: Citas
- `DataGridView` listado.
- `ComboBox` Paciente.
- `ComboBox` Médico.
- `DateTimePicker` Fecha/Hora.
- `ComboBox` **Estado** (Pendiente, Atendida, Cancelada).
- `GroupBox` “Receta” (**habilitar solo si Estado=ATENDIDA**).
  - Accesibilidad: `AccessibleName` y `AccessibleDescription` en el `GroupBox` con el mensaje “Las recetas solo se capturan para citas atendidas”.
  - Opcional: repetir `AccessibleDescription` en campos clave.
  - `TextBox` Diagnóstico.
  - `TextBox` Medicamento.
  - `TextBox` Dosis.
- Botones CRUD.

---

## Formulario: `FrmSuperAdminDashboard`
**Disposición:**
- Igual que `FrmAdminDashboard` + tab/panel exclusivo “Opciones Avanzadas”.

### Tab: Auditoría
- `DataGridView` log_auditoria.
- Filtros:
  - `DateTimePicker` Desde/Hasta.
  - `TextBox` Usuario.
  - `ComboBox` Acción (INSERT, UPDATE, DELETE).

### Tab: Roles y Permisos
- `DataGridView` Roles.
- `DataGridView` Usuarios-Roles.
- `CheckedListBox` Permisos (máscaras hexadecimales).
- Botones: Asignar rol, Quitar rol, Guardar permisos.

### Panel: Acciones críticas
- `Button` “Vaciar tablas”.
- `Button` “Ejecutar trigger manual”.
- `Button` “Generar respaldo”.
- `Label` advertencia.
- Confirmación con `MessageBox` antes de ejecutar.

---

# 3) Flujo de Pacientes

## Formulario: `FrmPacienteLogin`
**Disposición:**
- `Panel` central minimalista.

**Controles:**
- `TextBox` CURP (o ID).
- `DateTimePicker` Fecha de nacimiento (verificación simple).
- `Button` “Validar”.

---

## Formulario: `FrmPacienteDashboard`
**Disposición:**
- `TabControl` con tabs: **Perfil**, **Agendar Cita**, **Mis Citas**.

### Tab: Perfil
- `TextBox` Nombre.
- `TextBox` Apellidos.
- `TextBox` Teléfono.
- `TextBox` Email.
- `TextBox` CURP (solo lectura).
- `DateTimePicker` Fecha de nacimiento (solo lectura o editable según política).
- `ComboBox` Prioridad (visible).
  - Si no se permite edición: usar `Enabled = false` con `AccessibleDescription`: “Prioridad asignada por el personal médico; solo lectura”.
- `Button` “Guardar cambios”.

### Tab: Agendar Cita
- `ComboBox` Especialidad.
- `ComboBox` Médico (filtrado por especialidad).
- `DateTimePicker` Fecha.
- `ComboBox` Horario disponible.
- `Button` “Agendar”.

### Tab: Mis Citas
- `DataGridView` citas activas.
- `Label` Estado (Pendiente/Atendida/Cancelada).
- `Button` “Reprogramar” (solo para Pendiente).
- `Button` “Cancelar/Eliminar” (solo para Pendiente).

---

## Navegación sugerida (resumen)
- **FrmPortalInicio** → (Personal) `FrmStaffLogin` → `FrmAdminDashboard` / `FrmSuperAdminDashboard`.
- **FrmPortalInicio** → (Paciente) `FrmPacienteLogin` → `FrmPacienteDashboard`.
