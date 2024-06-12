import DSnote as ds
import note as n
import DScrawl as dsc
from tkinter import *
import ttkbootstrap as ttk
from ttkbootstrap import Style
import tkinter.messagebox as mb

class APPNOTE:
    def __init__(self, root):
        self.root = root
        self.listNote = ds.DSNOTE()
        self.listNote.docFile()

        self.frame_top = ttk.Frame(self.root, bootstyle='dark')
        self.frame_top.pack(side='top', fill='x')
        self.tieude_label = ttk.Label(self.frame_top, text="JOBS NOTE", font=("Helvetica",20, "bold"))
        self.tieude_label.pack(pady=10, padx=(10,0) , side='left')
        self.newNote_button = ttk.Button(self.frame_top, text="Tạo ghi chú mới", command=self.xoaEntry)
        self.newNote_button.pack(side='right', padx=(0, 30))


        self.frame_left = ttk.Frame(self.root)
        self.frame_left.pack(side='left', fill='y')
        self.scrollbar = ttk.Scrollbar(self.frame_left)
        self.note_listbox = ttk.Treeview(self.frame_left, columns=("Title"), show="headings", yscrollcommand=self.scrollbar.set)
        self.scrollbar.pack(side="right", fill="y")
        self.scrollbar.configure(command=self.note_listbox.yview)
        self.note_listbox.pack(side="left", fill="both", expand=True)
        self.note_listbox.heading("Title", text="Danh sách ghi chú")
        self.update_listbox()


        self.frame_right = ttk.Frame(self.root)
        self.frame_right.pack(fill='x')

        self.frame_right_tieude = ttk.Frame(self.frame_right)
        self.frame_right_tieude.pack(fill='x')

        self.tieude_text = ttk.Text(self.frame_right_tieude, height=1, font=('Helvetica', 18, 'italic'))
        self.tieude_text.pack(side='left',padx=50, pady=(30,0))

        self.frame_right_noidung = ttk.Frame(self.frame_right)
        self.frame_right_noidung.pack(fill='x')

        self.noidung_text = ttk.Text(self.frame_right_noidung, width=100, height=20, font=('Helvetica', 12))
        self.noidung_text.pack(side='left', padx=50, pady=(0, 30))

        self.Add_button = ttk.Button(self.frame_right, text="Thêm ghi chú", command=self.them_Note)
        self.Add_button.pack(side='right', padx=(0, 50), pady=(0, 30))

        self.note_listbox.bind("<<TreeviewSelect>>", self.chon_note)

        self.Update_button = ttk.Button(self.frame_right, text="Cập nhật ghi chú", command=self.capNhat_Note)
        self.Update_button.pack(side='right', padx=(0, 20), pady=(0, 30))

        self.Delete_button = ttk.Button(self.frame_right, text="Xoá ghi chú", command=self.xoa_Note)
        self.Delete_button.pack(side='right', padx=(0, 20), pady=(0, 30))

    def chon_note(self, event):
        selected_item = self.note_listbox.selection()
        if selected_item:
            selected_title = self.note_listbox.item(selected_item)['values'][0]
            selected_note = self.listNote.timNoteTheoTieuDe(selected_title)
            if selected_note:
                self.tieude_text.delete("1.0", "end")
                self.tieude_text.insert("1.0", selected_title)
                self.noidung_text.delete("1.0", "end")
                self.noidung_text.insert("1.0", selected_note['Noi dung'])

    def xoaEntry(self):
        self.tieude_text.delete("1.0", "end-1c")
        self.noidung_text.delete("1.0", "end-1c")

    def them_Note(self):
        tieude = self.tieude_text.get("1.0", "end-1c")
        noidung = self.noidung_text.get("1.0", "end-1c")
        self.listNote.taoNote(tieude, noidung)
        self.update_listbox()
        self.listNote.ghiFile()
        mb.showinfo("Thông báo", "Bạn đã thêm ghi chú thành công")

    def capNhat_Note(self):
        tieude = self.tieude_text.get("1.0", "end-1c")
        noidung = self.noidung_text.get("1.0", "end-1c")
        self.listNote.suaNote(tieude, noidung)
        self.listNote.ghiFile()

    def xoa_Note(self):
        tieude = self.tieude_text.get("1.0", "end-1c")
        self.listNote.xoaNote(tieude)
        self.update_listbox()
        self.listNote.ghiFile()
        self.xoaEntry()
        mb.showinfo("Thông báo", "Bạn đã xoá ghi chú")

        

    def update_listbox(self):
        for row in self.note_listbox.get_children():
            self.note_listbox.delete(row)
        for note in reversed(self.listNote.list):
            self.note_listbox.insert("", "end", values=(note['Tieu de'],))

class APPCRAWL:
    def __init__(self, root):
        self.root = root
        self.listJob = dsc.CRAWL()
        self.listJob.docFile()
        self.listJob.url = 'https://topdev.vn/viec-lam-it/ho-chi-minh-kl79?src=topdev.vn&medium=mainmenu'

        self.frame_top = ttk.Frame(self.root, bootstyle='dark')
        self.frame_top.pack(side='top', fill='x')
        self.tieude_label = ttk.Label(self.frame_top, text="JOBS NOTE", font=("Helvetica",20, "bold"))
        self.tieude_label.pack(pady=10, padx=(10,0) , side='left')
        self.newcrawl_button = ttk.Button(self.frame_top, text="Cào dữ liệu mới", command=self.crawl_data)
        self.newcrawl_button.pack(side='right', padx=(0, 30))
        
        self.frame_left = ttk.Frame(self.root)
        self.frame_left.pack(side='left', fill='y')
        self.scrollbar = ttk.Scrollbar(self.frame_left)
        self.job_listbox = ttk.Treeview(self.frame_left, columns=("Title"), show="headings", yscrollcommand=self.scrollbar.set)
        self.scrollbar.pack(side="right", fill="y")
        self.scrollbar.configure(command=self.job_listbox.yview)
        self.job_listbox.pack(side="left", fill="both", expand=True)
        self.job_listbox.heading("Title", text="Danh sách các Jobs")
        self.update_listbox()

        self.job_listbox.bind("<<TreeviewSelect>>", self.chon_job)

        self.frame_right = ttk.Frame(self.root)
        self.frame_right.pack(fill='x')


    def hienJob(self):
        self.tenjob = ttk.Label(self.frame_right)


    def crawl_data(self):
        self.listJob.crawl_data()
        self.update_listbox()

    def update_listbox(self):
        for row in self.job_listbox.get_children():
            self.job_listbox.delete(row)
        for i in reversed(self.listJob.list_data):
            self.job_listbox.insert("", "end", values=(i['title'],))
        
    def chon_job(self, event):
        self.frame_right.destroy()
        selected_item = self.job_listbox.selection()
        if selected_item:
            selected_title = self.job_listbox.item(selected_item)['values'][0]
            job = self.listJob.timJob(selected_title)
            if job:
                self.frame_right = ttk.Frame(self.root)
                self.frame_right.pack(fill='x')
                tenjob = ttk.Label(self.frame_right, text = job['title'], font=("Helvetica",16, "bold"), wraplength=850)
                tenjob.grid(padx=20, pady=20)

def main():
    root = Tk()
    root.geometry('1080x600+150+50')
    root.title("JOBS NOTE")
    style = Style("minty")
    #app = APPNOTE(root)
    app1 = APPCRAWL(root)
    root.mainloop()
    
    
if __name__ == '__main__':
    main()