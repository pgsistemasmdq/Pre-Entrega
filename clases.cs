/*
    public class Usuario
    {
        private long id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contraseña;
        private string mail;

        public void SetId(long id)
        {
            this.id = id;
        }
        public long GetId()
        {
            return id;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public string GetApellido()
        {
            return apellido;
        }

        public void SetNombreUsuario(string nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }
        public string GetNombreUsuario()
        {
            return nombreUsuario;
        }

        public void SetContraseña(string contraseña)
        {
            this.contraseña = contraseña;
        }
        public string GetContraseña()
        {
            return contraseña;
        }
        public void SetMail(string mail)
        {
            this.mail = mail;
        }
        public string GetMail()
        {
            return mail;
        }
        //METODO para setear todas las propiedades de una vez
        public void SetUsuario(long id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.mail = mail;

        }

    }

    public class Producto
    {
        private long id;
        private string descripcion;
        private double costo;
        private double precioVenta;
        private int stock;
        private long idUsuario;


        public void SetId(long id)
        {
            this.id = id;
        }
        public long GetId()
        {
            return id;
        }
        public void SetDescripcion(string des)
        {
            this.descripcion = des;
        }
        public string GetDescripcion()
        {
            return descripcion;
        }
        public void SetCosto(double costo)
        {
            this.costo = costo;
        }
        public double GetCosto()
        {
            return costo;
        }
        public void SetPrecioVenta(double p_venta)
        {
            this.precioVenta = p_venta;
        }
        public double GetPrecioVenta()
        {
            return precioVenta;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }
        public int GetStock()
        {
            return stock;
        }
        public void SetIdUsuario(long idUsuario)
        {
            this.idUsuario = idUsuario;
        }
        public long GetIdUsuario()
        {
            return idUsuario;
        }
        //METODO para setear todas las propiedades de una vez
        public void SetProducto(long id, string des, double costo, double precioVenta, int stock, long idUsuario)
        {
            this.id = id;
            this.descripcion = des;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;

        }
    }

    public class ProductoVendido
    {
        private long id;
        private long idProducto;
        private int stock;
        private long idVenta;

        public void SetId(long id)
        {
            this.id = id;
        }
        public long GetId()
        {
            return id;
        }
        public void SetIdProducto(long idProducto)
        {
            this.idProducto = idProducto;
        }
        public long GetIdProducto()
        {
            return idProducto;
        }
        public void SetStock(int stock)
        {
            this.stock = stock;
        }
        public int GetStock()
        {
            return stock;
        }
        public void SetIdVenta(long idVenta)
        {
            this.idVenta = idVenta;
        }
        public long GetIdVenta()
        {
            return idVenta;
        }

        //METODO para setear todas las propiedades de una vez
        public void SetProductoVendido(long id, long idProducto, int stock, long idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;

        }
    }

    public class Venta
    {
        private long id;
        private string comentarios;
        private long idUsuario;
        public void SetId(long id)
        {
            this.id = id;
        }
        public long GetId()
        {
            return id;
        }
        public void SetComentarios(string comentarios)
        {
            this.comentarios = comentarios;
        }
        public string GetComentarios()
        {
            return comentarios;
        }
        public void SetIdUsuario(long idUsuario)
        {
            this.idUsuario = idUsuario;
        }
        public long GetIdUsuario()
        {
            return idUsuario;
        }

        //METODO para setear todas las propiedades de una vez
        public void SetVenta(long id, string comentarios, long idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;

        }
    }

*/