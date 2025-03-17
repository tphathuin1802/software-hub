from PyQt6.QtWidgets import QApplication, QMainWindow
from connector.DBConnection import connect_to_sqlserver
from MyMainWindowLoginExt import LoginEx
# Khởi tạo ứng dụng PyQt
app = QApplication([])

# Kết nối đến SQL Server
server = "PHATHUYNH"
database = "HR"
conn = connect_to_sqlserver(server, database)

# Kiểm tra nếu kết nối thất bại
if conn is None:
    print("❌ Không thể kết nối đến cơ sở dữ liệu!")
else:
    print("✅ Kết nối thành công!")

# Tạo cửa sổ Login
mywin1 = LoginEx(conn)
mywin1.show()

# Chạy ứng dụng
app.exec()