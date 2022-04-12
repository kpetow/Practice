# Write a function that when given a URL as a string, parses out just the domain name and returns it as a string. For example:

# * url = "http://github.com/carbonfive/raygun" -> domain name = "github"
# * url = "http://www.zombie-bites.com"         -> domain name = "zombie-bites"
# * url = "https://www.cnet.com"                -> domain name = cnet"

import re

def domain_name(url):
    pattern1 = "www\W(.*?)\."
    pattern2 = "//(.*?)\."
    pattern3 = "(.*?)\."
    
    a = re.search(pattern1, url)
    if a:
        return a.group(1)

    b = re.search(pattern2, url)
    if b:
        return b.group(1)

    c = re.search(pattern3, url)
    if c:
        return c.group(1)


url = input(f'Enter a url: ')
print(domain_name(url))