cd src
docker build -t simplemathoperationsapi:v1 . -f "SimpleMathOperationsAPI\Dockerfile" --
cd ..
cd deploy
kubectl apply -f deployment.yaml
kubectl apply -f service.yaml
cd ..
