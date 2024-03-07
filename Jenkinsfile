pipeline {
    agent any
    stages{
        stage ('Git Checkout') {
            steps {
                cleanWs()
                git branch: 'Developpement', url: 'https://github.com/Bastien55/ServerGameOfLife.git'
            }
        }

        stage('Restore packages') {
            steps {
                bat "dotnet restore ${workspace}\\ServerGameOfLife.csproj"
            }
        }
        
        stage ('Build') {
            steps {
                bat "dotnet build ${workspace}\\ServerGameOfLife.csproj"
            }
        }
    }
}