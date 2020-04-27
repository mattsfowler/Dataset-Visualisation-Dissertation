import tkinter as tk
#import tkinter.ttk as ttk


class Application(tk.Frame):
    def __init__(self, master=None):
        super().__init__(master)
        self.master = master
        self.master.title("Test GUI")
        self.master.minsize(200, 150)
        self.pack()
        self.create_widgets()

    def add_menu_bar(self):
        # master menu bar
        menu_bar = tk.Menu(self.master)
        # "file" section
        file = tk.Menu(menu_bar)
        file.add_command(label="Exit", command=self.master.destroy)
        menu_bar.add_cascade(label="File", menu=file)
        # "edit" section
        edit = tk.Menu(menu_bar)
        edit.add_command(label="Nothing", command=None)
        menu_bar.add_cascade(label="Edit", menu=edit)
        # "help" section
        hlp = tk.Menu(menu_bar)
        hlp.add_command(label="Nothing", command=None)
        menu_bar.add_cascade(label="Help", menu=hlp)
        self.master.config(menu=menu_bar)

    def create_widgets(self):
        self.add_menu_bar()


if __name__ == "__main__":
    root = tk.Tk()
    app = Application(master=root)
    app.mainloop()
