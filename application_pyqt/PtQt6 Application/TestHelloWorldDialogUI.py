from PyQt6.QtWidgets import QApplication, QDialog

from FirstApplication import Ui_FirstApplication

app=QApplication([])
dialog=QDialog()
window = Ui_FirstApplication()
window.setupUi(dialog)
dialog.show()
app.exec()