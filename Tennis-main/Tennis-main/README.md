# Tennis Bole
Project for Hacklytics 2021

Authors: Ting Li, Lide Zhang, and Ruiyang Zhou.

## Inspiration
We are inspired by the increasing need for a platform that can help sports teams discover and recruit talents.  Therefore, we decided to participate in the GT Athletics tennis challenge, and we built a program that helps the GT tennis team to recruit possibly hidden young tennis talents.

## What it does and How we built it
The project can be divided into two parts: the fetcher and the analyzer. The fetcher is a web crawler written with Python and fetches players’ data such as names and scores from UTR and ATP Tour. The fetched data are stored as .csv files and can be read by the analyzer. 

The analyzer is a GUI program written with C#. It reads the .csv files, cross-references player data from UTR and ATP Tour, and generates unified player entries, removing players based on age limits. Then, based on the unified entries, the analyzer calculates a rank/score (called MyRank) based on UTR scores, ATP rankings, and user-defined weights. 

All players’ data are displayed in a list, sorted by MyRank in descending order to help coaches to identify prospects. Country statistics, such as average UTR, ATP, and MyRank of a country, are also presented for coaches to identify big opportunity areas.

## Challenges we ran into
The biggest challenge that we encountered is the network latency.  Living in China, the Great Fire Wall combined with the geographical distance largely prevent us from getting data from overseas websites. Another problem we faced was the login process on the UTR website. Due to some attributes of the login button, we failed to enable our code to execute the login process. To address this issue, we found the API offered by UTR and we managed to override the login process. Also, we have different language preferences and our project is a multilanguage project. However, we have little experience dealing with multilanguage coordination. 

## What we learned
- Web Scrapping
- WinForm GUI
- Multi-program Interaction
- Git

## What's next for Tennis Bole
In our feature endeavors, we are eager to add a feature that can better track the ranking trend of players.
