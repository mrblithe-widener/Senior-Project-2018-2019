from django.shortcuts import render
from django.http import HttpResponse
# Create your views here.

def home(request):
    return HttpResponse('<h1>Home Page</h1>')

def search(request):
    return HttpResponse('<h1>Search For A School</h1>')
