from bs4 import BeautifulSoup
import requests
import json
from tkinter import messagebox as mb

class CRAWL:
    def __init__(self):
        self.list_data = []
        self.url = ''

    def crawl_data(self):
        response = requests.get(self.url)
        if response.status_code == 200:
            print('Truy cap thanh cong')
            soup = BeautifulSoup(response.text, 'html.parser')
            all_info = soup.find_all('li', class_='mb-4 last:mb-0')
            for info in all_info:
                obj = {}
                p = info.find('h3')
                if p is None:
                    continue
                obj['title'] = p.find('a').text
                p = info.find('div', class_ = 'mt-1 line-clamp-1')
                obj['name company'] = p.find('a').text
                obj['poisition'] = info.find('p', class_='text-gray-500').text
                obj['adr'] = info.find('div', class_='flex flex-wrap items-end gap-2 text-gray-500').text
                p = info.find_all('a', class_ = 'mr-2 inline-block')
                tmp = []
                for i in p:
                    tmp.append(i.find('span').text)
                obj['lang'] = tmp
                self.list_data.append(obj)
            self.ghiFile()
            mb.showinfo('Thành công', 'Cào dữ liệu thành công')
        else:
            print(f'Truy cap khong thanh cong: {response.status_code}')

    def timJob(self, title):
        for job in self.list_data:
            if job['title'] == title:
                return job
        return None

    def docFile(self):
        try:
            with open('crawl_data.json', 'r') as f:
                temp = json.load(f)
                for i in temp:
                    self.list_data.append(i)
        except FileNotFoundError:
            print('File khong ton tai')
        except ValueError as ve:
            print(f'Loi: {ve}')
        except Exception as e:
            print(f'Loi khong xac dinh: {e}')

    def ghiFile(self):
        try:
            with open('crawl_data.json','w') as f:
                json.dump(self.list_data,f)
        except FileNotFoundError:
            print('File khong ton tai')
        except ValueError as ve:
            print(f'Loi: {ve}')
        except Exception as e:
            print(f'Loi khong xac dinh: {e}')
