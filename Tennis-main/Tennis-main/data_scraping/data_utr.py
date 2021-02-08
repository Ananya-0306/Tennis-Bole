'''
This program will capture all player's certain statistics through utr website 
'''
from urllib import request
from urllib.request import urlopen
import re
import json
import csv


# clear all data that has in the csv file
file = open('utr_data.csv', "w")
file.truncate()
file.close()
# write the csv header
header = ['Name', 'Age', 'Gender', 'Nationality', 'Ranking']
with open('utr_data.csv', 'w', newline='') as csvfile:
    spamwriter = csv.writer(csvfile, delimiter=',',
                            quotechar=',', quoting=csv.QUOTE_MINIMAL)
    spamwriter.writerow(header)

def get_all_ID():  # get all player's id
    site = 'https://app.myutr.com/api/v2/search'
    f = urlopen(site)
    search_file = f.read()
    f.close()
    web_info = str(search_file, 'UTF-8')
    # print(type(web_info))
    # recognize the player's id
    player_id_r = r'"playerId":[0-9]+'
    player_ids = re.compile(player_id_r)
    ids = re.findall(player_ids, web_info)
    # print(type(ids))
    # create a id list
    id_list = []
    for id in ids:
        if id not in id_list:
            id_list.append(id)
    # print(id_list)
    # get only id number
    number_list = []
    for iD in id_list:
        # iD = iD.replace('"playerID":','')
        iD = iD[11:]
        number_list.append(iD)
    return number_list
    # print(number_list)
    # num = 0
    # for number in number_list:
    #    num += 1
    # print(num)


# player_profiles = []
for ID in get_all_ID():
    # go through all player's web
    web = request.urlopen('https://app.myutr.com/api/v2/player/' + ID)
    # read the json of the web
    hjson = json.loads(web.read())
    profile = []
    # find name
    name = hjson['displayName']
    profile.append(str(name))
    # find age
    age = hjson['age']
    profile.append(str(age))
    # find gender
    gender = hjson['gender']
    profile.append(str(gender))
    # find nationality
    nationality = hjson['location']['countryIoc']
    profile.append(str(nationality))
    # find the singleutr score
    singlesutr = hjson['singlesUtr']
    profile.append(str(singlesutr))

    #    college = hjson['collegeRecruiting']
    #    profile.append(str(college))
    print(profile)
    # write the data about the player into csv file
    with open('utr_data.csv', 'a', newline='') as csvfile:
        spamwriter = csv.writer(csvfile, delimiter=',',
                                quotechar=',', quoting=csv.QUOTE_MINIMAL)
        spamwriter.writerow(profile)
#    player_profiles.append(profile)
