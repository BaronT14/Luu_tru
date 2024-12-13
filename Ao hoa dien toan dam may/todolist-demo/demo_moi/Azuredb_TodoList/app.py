from flask import Flask, render_template, request, redirect, url_for
import pyodbc

app = Flask(__name__)

# Cấu hình kết nối
server = 'baron.database.windows.net'
database = 'db_todo'
username = 'baron'
password = 'Van1404@Thanh'
driver = '{ODBC Driver 17 for SQL Server}'

# Hàm kết nối đến Azure SQL Database
def connect_to_db():
    return pyodbc.connect(
        f'DRIVER={driver};SERVER={server};PORT=1433;DATABASE={database};UID={username};PWD={password}'
    )

# Trang chủ - Hiển thị danh sách công việc
@app.route('/')
def index():
    try:
        connection = connect_to_db()
        cursor = connection.cursor()

        # Lấy danh sách công việc và danh mục
        cursor.execute("""
            SELECT t.TaskID, t.Description, t.IsCompleted, t.DueDate, t.CreatedDate, c.Name AS Category
            FROM Tasks t
            LEFT JOIN Categories c ON t.CategoryID = c.CategoryID
            ORDER BY t.TaskID ASC
        """)
        tasks = cursor.fetchall()

        # Lấy danh sách danh mục
        cursor.execute("SELECT * FROM Categories")
        categories = cursor.fetchall()

        return render_template('index.html', tasks=tasks, categories=categories, filters={})
    except Exception as e:
        return f"Lỗi khi truy vấn dữ liệu: {e}"
    finally:
        if 'connection' in locals():
            connection.close()

# Thêm công việc mới
@app.route('/add', methods=['POST'])
def add_task():
    description = request.form['description']
    due_date = request.form['due_date']
    category_id = request.form.get('category_id', None)
    is_completed = 1 if 'is_completed' in request.form else 0  # Lấy trạng thái từ form

    try:
        connection = connect_to_db()
        cursor = connection.cursor()
        cursor.execute("""
            INSERT INTO Tasks (Description, DueDate, CategoryID, IsCompleted) 
            VALUES (?, ?, ?, ?)
        """, (description, due_date, category_id, is_completed))
        connection.commit()
        return redirect(url_for('index'))
    except Exception as e:
        return f"Lỗi khi thêm dữ liệu: {e}"
    finally:
        if 'connection' in locals():
            connection.close()

# Cập nhật trạng thái công việc
@app.route('/complete/<int:task_id>')
def complete_task(task_id):
    try:
        connection = connect_to_db()
        cursor = connection.cursor()
        cursor.execute("UPDATE Tasks SET IsCompleted = 1 WHERE TaskID = ?", (task_id,))
        connection.commit()
        return redirect(url_for('index'))
    except Exception as e:
        return f"Lỗi khi cập nhật dữ liệu: {e}"
    finally:
        if 'connection' in locals():
            connection.close()

# Xóa công việc
@app.route('/delete/<int:task_id>')
def delete_task(task_id):
    try:
        connection = connect_to_db()
        cursor = connection.cursor()
        cursor.execute("DELETE FROM Tasks WHERE TaskID = ?", (task_id,))
        connection.commit()
        return redirect(url_for('index'))
    except Exception as e:
        return f"Lỗi khi xóa dữ liệu: {e}"
    finally:
        if 'connection' in locals():
            connection.close()

# Sửa công việc
@app.route('/edit/<int:task_id>', methods=['GET', 'POST'])
def edit_task(task_id):
    if request.method == 'POST':
        description = request.form['description']
        due_date = request.form['due_date']
        category_id = request.form.get('category_id', None)
        is_completed = 1 if 'is_completed' in request.form else 0  # Lấy trạng thái từ form

        try:
            connection = connect_to_db()
            cursor = connection.cursor()
            cursor.execute("""
                UPDATE Tasks 
                SET Description = ?, DueDate = ?, CategoryID = ?, IsCompleted = ?
                WHERE TaskID = ?
            """, (description, due_date, category_id, is_completed, task_id))
            connection.commit()
            return redirect(url_for('index'))
        except Exception as e:
            return f"Lỗi khi cập nhật dữ liệu: {e}"
        finally:
            if 'connection' in locals():
                connection.close()
    else:
        try:
            connection = connect_to_db()
            cursor = connection.cursor()
            cursor.execute("SELECT * FROM Tasks WHERE TaskID = ?", (task_id,))
            task = cursor.fetchone()

            cursor.execute("SELECT * FROM Categories")
            categories = cursor.fetchall()

            return render_template('edit.html', task=task, categories=categories)
        except Exception as e:
            return f"Lỗi khi truy vấn dữ liệu: {e}"
        finally:
            if 'connection' in locals():
                connection.close()

# Tìm kiếm và lọc công việc
@app.route('/search', methods=['GET'])
def search_task():
    keyword = request.args.get('keyword', '')
    category_id = request.args.get('category_id', '')
    is_completed = request.args.get('is_completed', '')

    try:
        connection = connect_to_db()
        cursor = connection.cursor()

        query = """
            SELECT t.TaskID, t.Description, t.IsCompleted, t.DueDate, t.CreatedDate, c.Name AS Category
            FROM Tasks t
            LEFT JOIN Categories c ON t.CategoryID = c.CategoryID
            WHERE t.Description LIKE ? 
        """
        params = [f"%{keyword}%"]

        if category_id:
            query += " AND t.CategoryID = ?"
            params.append(category_id)
        if is_completed:
            query += " AND t.IsCompleted = ?"
            params.append(is_completed)

        cursor.execute(query, params)
        tasks = cursor.fetchall()

        cursor.execute("SELECT * FROM Categories")
        categories = cursor.fetchall()

        return render_template('index.html', tasks=tasks, categories=categories, filters=request.args)
    except Exception as e:
        return f"Lỗi khi truy vấn dữ liệu: {e}"
    finally:
        if 'connection' in locals():
            connection.close()

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=5000)
