'''
This program will capture all players meets match from atptour.com
'''

from bs4 import BeautifulSoup
import requests
import csv

# clear all data that has in the csv file
f = open("atp_data.csv", "w")
f.truncate()
f.close()
# create a list contains all matched players and headers
all_players = [['Name', 'Age', 'Gender', 'Nationality', 'Ranking']]

# headers used to request for url
headers = {
    'user-agent': ''}
# url for atp
url = 'https://www.atptour.com/en/rankings/singles/?rankDate=2021-2-1&countryCode=all&rankRange=600-2200'
response = requests.get(url, headers=headers)
file = BeautifulSoup(response.content, 'html.parser')
count = 0  # count the player's position in the html
mytd = file.find_all('td', {'class': 'age-cell'})  # find all players' cells in html
for tds in mytd:
    print(tds.text.strip())
    if tds.text.strip() != '' and int(tds.text.strip()) <= 18:  # find player who is less than 18 years'olds website

        link = file.select('.player-cell a')[count]['href']  # get the part for the player's site's html

        personal_web = 'https://www.atptour.com' + link  # whole html
        print(personal_web)

        # print(personal_web)
        res = requests.get(personal_web, headers=headers)  # read the player's site
        profile = BeautifulSoup(res.content, 'html.parser')

        info_list = []
        first_name = profile.find('div', {'class': 'first-name'})  # get first name

        last_name = profile.find('div', {'class': 'last-name'})  # get last name
        name = first_name.text.strip() + ' ' + last_name.text.strip()  # get the whole name
        info_list.append(name)

        find_age = str(profile.find('div', {'class': 'table-big-value'}))  # find the age
        age = find_age[31:33]
        info_list.append(age)

        info_list.append('Male')  # all single men player

        country = profile.find('div', {'class': "player-flag-code"})  # find the nationality
        nationality = country.text.strip()
        info_list.append(nationality)

        infos = profile.findAll('div', {'class': 'stat-value'})  # find rank and total priaze they win
        for info in infos:
            if '$' in info.text.strip():
                info.text.strip().replace('$', '')
                info_list.append(info.text.strip().replace('$', ''))
            else:
                info_list.append(info.text.strip())

        if int(info_list[11]) < 10000:  # if they won more than 10000, exclude them
            player_info = info_list[0:5]
            all_players.append(player_info)
    count += 1

for player in all_players:  # write to the csv file
    with open('atp_data.csv', 'a', newline='') as csvfile:
        spamwriter = csv.writer(csvfile, delimiter=',',
                                quoting=csv.QUOTE_MINIMAL, quotechar=',')
        spamwriter.writerow(player)
