import pyodbc
def connect_to_sqlserver(server, database, username=None, password=None, trusted_connection=True):
    try:
        if trusted_connection:
            conn_str = f"DRIVER={{SQL Server}};SERVER={server};DATABASE={database};Trusted_Connection=yes;"
        else:
            conn_str = f"DRIVER={{SQL Server}};SERVER={server};DATABASE={database};UID={username};PWD={password};"
        conn = pyodbc.connect(conn_str)
        print("SQL Server Connected")
        return conn
    except Exception as e:
        print(f"Could not establish a connection to SQL Server: {e}")
        return None