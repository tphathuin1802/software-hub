from PyQt6.QtWidgets import QMainWindow, QMessageBox
from MyMainWindowLogin import Ui_MainWindow

class LoginEx(QMainWindow, Ui_MainWindow):
    def __init__(self, conn):
        super().__init__()
        self.conn = conn
        self.setupUi(self)
        self.pushButtonLogin.clicked.connect(self.Login)
        self.pushButtonExit.clicked.connect(self.Exit)

    def Login(self):
        if self.conn:
            cursor = self.conn.cursor()
            cursor.execute("SELECT * FROM 15_03_K234131613")
            accs = cursor.fetchall()

            username_input = self.lineEditLogin.text().lower().strip()
            password_input = self.lineEditPassword.text().lower().strip()

            for col1, col2, col3 in accs:
                if username_input == str(col1) and password_input == str(col2).lower().strip():
                    mgs = QMessageBox(self)  # Đảm bảo hộp thoại hiển thị trên cửa sổ hiện tại
                    mgs.setWindowTitle("Thông báo")
                    mgs.setText("Đăng nhập thành công rồi nha!")
                    mgs.setIcon(QMessageBox.Icon.Information)
                    mgs.exec()  # Hiển thị hộp thoại
                    self.close()  # Đóng cửa sổ đăng nhập
                    return

    def Exit(self):
        dlg = QMessageBox(self.MainWindow)
        dlg.setWindowTitle("Exit Confirmation")
        dlg.setText("Are you sure you want to Exit?")
        dlg.setStandardButtons(
            QMessageBox.StandardButton.Yes
            | QMessageBox.StandardButton.No
        )
        dlg.setIcon(QMessageBox.Icon.Question)
        button = dlg.exec()
        # check the user confirmation
        button = QMessageBox.StandardButton(button)
        if button == QMessageBox.StandardButton.Yes:
            self.MainWindow.close()
        else:
            pass  # do nothing
            # Nếu không tìm thấy tài khoản phù hợp
            mgs = QMessageBox(self)
            mgs.setWindowTitle("Thông báo")
            mgs.setText("Đăng nhập không thành công!")
            mgs.setIcon(QMessageBox.Icon.Warning)
            mgs.exec()