pipeline {
    agent any
    tools {
        msbuild 'MSBuild2022'
    }
    stages {
        stage('Build') {
            steps {
                script {
                    bat 'UnitTestProject1.sln /p:Configuration=Release %MSBUILD_ARGS%'
                }
            }
        }
    }
    stage('SonarQube Scan') {
        steps {
            withSonarQubeEnv('MySonarQube') {
            bat "mvn sonar:sonar -Dsonar.token=sqa_50f2d97973de8bd8f31420468de466c25be20838"
            }				
        }
    }
}